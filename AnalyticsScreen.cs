using Cyber_DefenderTCG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cyber_DefenderTCG
{
    public partial class AnalyticsScreen : Form
    {
        private User authenticatedUser;
        private string connString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppDomain.CurrentDomain.BaseDirectory}CyberDefenderDatabase.accdb;Persist Security Info=False;";
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public AnalyticsScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            StyleTerminalGrid(GlobalLogsDGV);

            this.VisibleChanged += Analytics_VisibleChanged;
            

        }
        private void Analytics_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                RefreshAllAnalytics();

            }
        }

        private void RefreshAllAnalytics()
        {
            LoadGlobalMatchLogs();
            LoadDemographicsChart();
            LoadRatingsChart();
            LoadAgeChart();
            LoadRankChart();
        }

        private async void ReturnToMMenuButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalAdminMainMenu;
            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
        }

        private void LoadGlobalMatchLogs()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = @"SELECT M.LogId, M.UserId, U.UserName, M.DatePlayed, M.Difficulty, M.HealthRemaining 
                         FROM MatchLogs M 
                         INNER JOIN UserAccounts U ON M.UserId = U.UserID 
                         ORDER BY M.DatePlayed DESC";
                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    GlobalLogsDGV.DataSource = dt;
                    GlobalLogsDGV.AutoResizeColumns();
                }
                catch (Exception ex) { MessageBox.Show("Log Fetch Error: " + ex.Message); }
            }
        }
        private void LoadDemographicsChart()
        {
            DemographicChart.Series.Clear();
            var series = DemographicChart.Series.Add("Gender Distribution");
            series.ChartType = SeriesChartType.Pie; 

            int male = 0; int female = 0;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = "SELECT LCase(Trim(CharacterGender)) as Gen, COUNT(*) as Tot FROM UserAccounts GROUP BY LCase(Trim(CharacterGender))";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string g = reader["Gen"].ToString();
                        int c = Convert.ToInt32(reader["Tot"]);
                        if (g == "male") male = c;
                        if (g == "female") female = c;

                        string label = char.ToUpper(g[0]) + g.Substring(1);
                        series.Points.AddXY(label, c);
                    }
                }
            }
            series["PieLabelStyle"] = "Inside"; 
            series.IsValueShownAsLabel = true;
            DemographicsDataLabel.Text = $"DATA ANALYSIS:\nTotal Agents: {male + female}\nMale: {male}\nFemale: {female}";
            StyleChart(DemographicChart);
        }

        private void LoadAgeChart()
        {
            AgeChart.Series.Clear();
            var series = AgeChart.Series.Add("Age Groups");
            series.ChartType = SeriesChartType.Pie;

            string mostCommonAge = "N/A";
            int maxCount = -1;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                
                string query = @"SELECT 
            Switch(Age < 18, 'Under 18', Age >= 18 AND Age <= 25, '18-25', Age >= 26 AND Age <= 35, '26-35', Age > 35, '35+') as Grp, 
            COUNT(*) as Tot FROM UserAccounts 
            WHERE Age IS NOT NULL 
            GROUP BY Switch(Age < 18, 'Under 18', Age >= 18 AND Age <= 25, '18-25', Age >= 26 AND Age <= 35, '26-35', Age > 35, '35+')";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string group = reader["Grp"].ToString();
                        int count = Convert.ToInt32(reader["Tot"]);
                        series.Points.AddXY(group, count);

                        if (count > maxCount) { maxCount = count; mostCommonAge = group; }
                    }
                }
            }
            series["PieLabelStyle"] = "Inside"; 
            series.IsValueShownAsLabel = true;
            AgeDataLabel.Text = $"AGE LOGS:\nMost Common: {mostCommonAge}\nMode Frequency: {maxCount} agents";
            StyleChart(AgeChart);
        }
        private void LoadRatingsChart()
        {
            RatingChart.Series.Clear();
            var sMatch = RatingChart.Series.Add("Match");
            sMatch.ChartType = SeriesChartType.Column;

            GameRatingChart.Series.Clear();
            var sGame = GameRatingChart.Series.Add("General");
            sGame.ChartType = SeriesChartType.Column;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                RatingsDataLabel.Text = "MATCH TELEMETRY:\n" + CalculateStats(conn, "MatchFeedback", sMatch);
                GameRatingDataLabel.Text = "GAME TELEMETRY:\n" + CalculateStats(conn, "GameReviews", sGame);
            }

            StyleChart(RatingChart);
            StyleChart(GameRatingChart);
        }

        private string CalculateStats(OleDbConnection conn, string table, Series series)
        {
            List<int> vals = new List<int>();
            Dictionary<int, int> counts = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };

            using (var reader = new OleDbCommand($"SELECT Rating FROM {table}", conn).ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader["Rating"] != DBNull.Value)
                    {
                        int r = Convert.ToInt32(reader["Rating"]);
                        vals.Add(r);
                        if (counts.ContainsKey(r)) counts[r]++;
                    }
                }
            }

            foreach (var kvp in counts)
            {
                int i = series.Points.AddXY(kvp.Key, kvp.Value);

                series.Points[i].AxisLabel = kvp.Key + "★";

                if (kvp.Key <= 2) series.Points[i].Color = Color.Salmon;
                else if (kvp.Key == 3) series.Points[i].Color = Color.Yellow;
                else series.Points[i].Color = Color.LimeGreen;
            }

            if (vals.Count == 0) return "No data packet received.";

            double mean = vals.Average();
            vals.Sort();
            double median = (vals.Count % 2 == 0)
                ? (vals[vals.Count / 2] + vals[vals.Count / 2 - 1]) / 2.0
                : vals[vals.Count / 2];

            var modeGroup = vals.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault();
            int mode = modeGroup != null ? modeGroup.Key : 0;

            return $"Mean: {mean:F2}\nMedian: {median:F1}\nMode: {mode}";
        }
        private void StyleChart(Chart chart)
        {
            if (chart.ChartAreas.Count == 0) return;
            var area = chart.ChartAreas[0];
            area.BackColor = Color.Transparent;

            
            area.AxisY.LabelStyle.ForeColor = Color.White;
            area.AxisY.LineColor = Color.Cyan;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(40, Color.Gray);
            area.AxisY.IsStartedFromZero = true;
            area.AxisY.Minimum = 0;

            area.AxisX.LabelStyle.ForeColor = Color.White;
            area.AxisX.LineColor = Color.Cyan;
            area.AxisX.Interval = 1;

            foreach (var series in chart.Series)
            {
                series.IsValueShownAsLabel = true; 
                series.LabelForeColor = Color.Cyan;
                series.Font = new Font("Consolas", 8f, FontStyle.Bold);
            }
        }
        private void StyleTerminalGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(20, 20, 30); 
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void LoadRankChart()
        {
            RankChart.Series.Clear();
            RankChart.ChartAreas[0].BackColor = Color.Transparent;
            RankChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            RankChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            RankChart.ChartAreas[0].AxisX.LineColor = Color.Cyan;
            RankChart.ChartAreas[0].AxisY.LineColor = Color.Cyan;
            
            var series = RankChart.Series.Add("Agent Rank Distribution");
            series.LabelForeColor = Color.White;
            series.ChartType = SeriesChartType.Pie; 

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = "SELECT TotalXP FROM UserAccounts";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                var rankCounts = new Dictionary<string, int> {
            { "Script Kiddie", 0 }, { "System Drifter", 0 }, { "Data Freelancer", 0 },
            { "Cyber Sentinel", 0 }, { "Netrunner", 0 }, { "Grand Architect", 0 }
        };

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int xp = reader["TotalXP"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TotalXP"]);

                            int level = (xp / 100) + 1;
                            string title;
                            if (level <= 15) title = "Script Kiddie";
                            else if (level <= 30) title = "System Drifter";
                            else if (level <= 50) title = "Data Freelancer";
                            else if (level <= 75) title = "Cyber Sentinel";
                            else if (level <= 99) title = "Netrunner";
                            else title = "Grand Architect";

                            rankCounts[title]++;
                        }
                    }
                    foreach (var rank in rankCounts)
                    {
                        if (rank.Value > 0) 
                            series.Points.AddXY(rank.Key, rank.Value);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }





    }
}
