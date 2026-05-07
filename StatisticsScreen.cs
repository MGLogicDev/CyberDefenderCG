using Cyber_DefenderTCG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cyber_DefenderTCG
{
    public partial class StatisticsScreen : Form
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
        public StatisticsScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            StyleTerminalGrid(HistoryDGV);
            this.VisibleChanged += StatisticsScreen_VisibleChanged;


        }
        private void StyleTerminalGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(20, 20, 30); 
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 45);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void StatisticsScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadOverview();
                LoadCombatStats();
                LoadDifficultyBreakdown();
                LoadMatchHistory();
            }
        }
        private void LoadOverview()
        {
            UpdateAgentIdentityUI();

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = @"SELECT COUNT(*) AS Tot, 
                         SUM(CorrectChoices) AS Cor, 
                         SUM(IncorrectChoices) AS Wrng 
                         FROM MatchLogs WHERE UserId = ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", authenticatedUser.UserID);

                try
                {
                    conn.Open();

                    int totalMatches = 0;
                    int totalCorrect = 0;
                    int totalWrong = 0;

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalMatches = reader["Tot"] != DBNull.Value ? Convert.ToInt32(reader["Tot"]) : 0;
                            totalCorrect = reader["Cor"] != DBNull.Value ? Convert.ToInt32(reader["Cor"]) : 0;
                            totalWrong = reader["Wrng"] != DBNull.Value ? Convert.ToInt32(reader["Wrng"]) : 0;
                        }
                    } 
                    MatchesPlayedLabel.Text = totalMatches.ToString();

                    if (totalCorrect + totalWrong > 0)
                    {
                        double acc = ((double)totalCorrect / (totalCorrect + totalWrong)) * 100;
                        CareerAccuracyLabel.Text = $"{acc:F1}%";
                    }
                    else CareerAccuracyLabel.Text = "0.0%";

                    cmd.CommandText = "SELECT COUNT(*) FROM MatchLogs WHERE UserId = ? AND HealthRemaining > 0";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("?", authenticatedUser.UserID);

                    int wins = Convert.ToInt32(cmd.ExecuteScalar()); 
                    int losses = totalMatches - wins;

                    WinLossLabel.Text = $"{wins}W - {losses}L";

                    if (totalMatches > 0)
                    {
                        double wr = ((double)wins / totalMatches) * 100;
                        WinRateLabel.Text = $"{wr:F0}%";
                    }
                    else WinRateLabel.Text = "0%";


                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Analytics Engine Error: " + ex.Message);
                }
            }
        }        private void UpdateAgentIdentityUI()
        {
            if (authenticatedUser == null) return;

            UsernameLabel.Text = $"Agent {authenticatedUser.Username.ToUpper()}";
            UsernameLabel.Refresh();

            TotalXPLabel.Text = $"{authenticatedUser.XP} XP";
            TotalXPLabel.Refresh();

            CurrentLevelLabel.Text = $" {authenticatedUser.Level} lvl";

            RankLabel.Text = authenticatedUser.GetRankTitle();
            RankLabel.Refresh();

            

            int progress = authenticatedUser.XP % 1000;
            XPProgressBar.Value = Math.Min(100, progress / 10);
            XPProgressBar.Refresh();

            string rank = authenticatedUser.GetRankTitle().ToLower();
            if (rank.Contains("script kiddie"))
            {
                RankPbox.Image = Properties.Resources.ScriptKiddie;
                ScriptKiddiePbox.Image = Properties.Resources.ScriptKiddie;
            }
            else if (rank.Contains("system drifter"))
            {
                RankPbox.Image = Properties.Resources.SystemDrifter;
                ScriptKiddiePbox.Image = Properties.Resources.ScriptKiddie;
                SystemDrifterPbox.Image = Properties.Resources.SystemDrifter;   
            }
            else if (rank.Contains("data freelancer"))
            {
                RankPbox.Image = Properties.Resources.DataFreelancer;
                ScriptKiddiePbox.Image = Properties.Resources.ScriptKiddie;
                SystemDrifterPbox.Image = Properties.Resources.SystemDrifter;
                DataFreelancerPbox.Image = Properties.Resources.DataFreelancer;
            }
            else if (rank.Contains("cyber sentinel"))
            {
                RankPbox.Image = Properties.Resources.CyberSentinel;
                ScriptKiddiePbox.Image = Properties.Resources.ScriptKiddie;
                SystemDrifterPbox.Image = Properties.Resources.SystemDrifter;
                DataFreelancerPbox.Image = Properties.Resources.DataFreelancer;
                CyberSentinelPbox.Image = Properties.Resources.CyberSentinel;
            }
            else if (rank.Contains("netrunner"))
            {
                RankPbox.Image = Properties.Resources.Netrunner;
                ScriptKiddiePbox.Image = Properties.Resources.ScriptKiddie;
                SystemDrifterPbox.Image = Properties.Resources.SystemDrifter;
                DataFreelancerPbox.Image = Properties.Resources.DataFreelancer;
                CyberSentinelPbox.Image = Properties.Resources.CyberSentinel;
                NetrunnerPbox.Image = Properties.Resources.Netrunner;
            }
            else
            {
                RankPbox.Image = Properties.Resources.GrandArchitect;
                ScriptKiddiePbox.Image = Properties.Resources.ScriptKiddie;
                SystemDrifterPbox.Image = Properties.Resources.SystemDrifter;
                DataFreelancerPbox.Image = Properties.Resources.DataFreelancer;
                CyberSentinelPbox.Image = Properties.Resources.CyberSentinel;
                NetrunnerPbox.Image = Properties.Resources.Netrunner;
                GrandArchitectPbox.Image = Properties.Resources.GrandArchitect;

            }

            RankPbox.Refresh();
        }

        private async void ReturnToMMenuButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalMainMenu;
            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
        }

        private void LoadCombatStats()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT MAX(HealthRemaining) FROM MatchLogs WHERE UserId = ? AND HealthRemaining > 0", conn);
                    cmd.Parameters.AddWithValue("UserID", authenticatedUser.UserID);
                    object resHealth = cmd.ExecuteScalar();
                    BestHealthLabel.Text = (resHealth != DBNull.Value && resHealth != null) ? $"{resHealth}%" : "---";

                    cmd.CommandText = "SELECT SUM(CorrectChoices) FROM MatchLogs WHERE UserId = ?";
                    cmd.Parameters.Clear(); 
                    cmd.Parameters.AddWithValue("UserID", authenticatedUser.UserID);
                    object resThreats = cmd.ExecuteScalar();
                    ThreatsDefendedLabel.Text = (resThreats != DBNull.Value && resThreats != null) ? resThreats.ToString() : "0";
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
        private void LoadDifficultyBreakdown()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                EasyWinsLabel.Text = GetCount(conn, "easy");
                MediumWinsLabel.Text = GetCount(conn, "medium");
                HardWinsLabel.Text = GetCount(conn, "hard");
                EndlessWinsLabel.Text = GetEndlessHighscore(conn);
            }
        }

        private string GetCount(OleDbConnection conn, string diff)
        {
            string q = "SELECT COUNT(*) FROM Matches WHERE UserID = ? AND IsVictory = True AND LCase(Difficulty) = ?";
            using (OleDbCommand cmd = new OleDbCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("?", authenticatedUser.UserID);
                cmd.Parameters.AddWithValue("?", diff);
                return cmd.ExecuteScalar().ToString();
            }
        }

        private string GetEndlessHighscore(OleDbConnection conn)
        {
            string q = "SELECT MAX(CorrectChoices) FROM Matches WHERE UserID = ? AND LCase(Difficulty) = 'endless'";
            using (OleDbCommand cmd = new OleDbCommand(q, conn))
            {
                cmd.Parameters.AddWithValue("?", authenticatedUser.UserID);
                object res = cmd.ExecuteScalar();
                return res != DBNull.Value ? $"{res}" : "0";
            }
        }
        private void LoadMatchHistory()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = @"SELECT DatePlayed, Difficulty, CorrectChoices, IncorrectChoices, HealthRemaining 
                         FROM MatchLogs 
                         WHERE UserId = @UID 
                         ORDER BY DatePlayed DESC";

                OleDbCommand cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue("@UID", authenticatedUser.UserID);

                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Console.WriteLine($"[DB Debug] Rows found: {dt.Rows.Count} for User: {authenticatedUser.UserID}");

                    HistoryDGV.DataSource = null;
                    HistoryDGV.AutoGenerateColumns = true;
                    HistoryDGV.DataSource = dt;

                    StyleHistoryGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Telemetry Sync Error: " + ex.Message);
                }
            }
        }

        private void StyleHistoryGrid()
        {
            if (HistoryDGV.Columns.Count == 0) return;

            if (HistoryDGV.Columns.Contains("DatePlayed")) HistoryDGV.Columns["DatePlayed"].HeaderText = "TIMESTAMP";
            if (HistoryDGV.Columns.Contains("CorrectChoices")) HistoryDGV.Columns["CorrectChoices"].HeaderText = "NEUTRALIZED";
            if (HistoryDGV.Columns.Contains("IncorrectChoices")) HistoryDGV.Columns["IncorrectChoices"].HeaderText = "BREACHES";
            if (HistoryDGV.Columns.Contains("HealthRemaining")) HistoryDGV.Columns["HealthRemaining"].HeaderText = "INTEGRITY";

            foreach (DataGridViewRow row in HistoryDGV.Rows)
            {
                var healthCell = row.Cells["HealthRemaining"];
                if (healthCell.Value != null && healthCell.Value != DBNull.Value)
                {
                    int health = Convert.ToInt32(healthCell.Value);

                    if (health > 0)
                    {
                        healthCell.Style.ForeColor = Color.Lime;
                        healthCell.Style.SelectionForeColor = Color.Lime;
                    }
                    else
                    {
                        healthCell.Style.ForeColor = Color.Red;
                        healthCell.Style.SelectionForeColor = Color.Red;
                    }
                }
            }
        }

    }
}
