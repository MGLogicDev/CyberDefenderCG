using Cyber_DefenderTCG.Classes;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cyber_DefenderTCG
{
    public partial class ReviewsScreen : Form
    {
        private string connString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppDomain.CurrentDomain.BaseDirectory}CyberDefenderDatabase.accdb;Persist Security Info=False;";
        private User authenticatedUser;
        private DataTable feedbackTable;
        private DataTable supportTable;
        Helper helper = new Helper();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public ReviewsScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;

            StyleTerminalGrid(FeedbackDGV);
            StyleTerminalGrid(SupportDGV);
            StyleTerminalGrid(AccountsDGV);

            FeedbackSearchTxb.TextChanged += FeedbackSearchTxb_TextChanged;
            SupportSearchTxb.TextChanged += SupportSearchTxb_TextChanged;
            SupportDGV.CellContentClick += SupportDGV_CellContentClick;
            AccountsDGV.SelectionChanged += AccountsDGV_SelectionChanged;

            this.VisibleChanged += ReviewsScreen_VisibleChanged;
        }
        private void ReviewsScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                RefreshAllAdminData();
            }
        }

        private void RefreshAllAdminData()
        {
            LoadFeedbackData();
            LoadSupportData();
            LoadAllAccounts();
        }
        private void LoadFeedbackData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = @"
            SELECT 'GAME_REVIEW' AS Source, UserID, Rating, Suggestion, DateSubmitted 
            FROM GameReviews
            UNION ALL
            SELECT 'MATCH_FEEDBACK' AS Source, UserID, Rating, Suggestion, DateSubmitted 
            FROM MatchFeedback
            ORDER BY DateSubmitted DESC";

                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    feedbackTable = new DataTable();
                    adapter.Fill(feedbackTable);
                    FeedbackDGV.DataSource = feedbackTable;
                    FeedbackDGV.Columns["Suggestion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                    FeedbackDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (FeedbackDGV.Columns.Contains("Rating"))
                        FeedbackDGV.Columns["Rating"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (FeedbackDGV.Columns.Contains("UserID"))
                        FeedbackDGV.Columns["UserID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    if (FeedbackDGV.Columns.Contains("Source"))
                        FeedbackDGV.Columns["Source"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FEEDBACK ERROR: One of your tables (GameReviews or MatchFeedback) " +
                        "might be missing 'Suggestion' or 'DateSubmitted'.\n\nDetails: " + ex.Message);
                }
            }
        }

        private void FeedbackSearchTxb_TextChanged(object sender, EventArgs e)
        {
            if (feedbackTable == null) return;
            feedbackTable.DefaultView.RowFilter = string.Format("Source LIKE '%{0}%' OR Suggestion LIKE '%{0}%' OR Source LIKE '%{0}%'", FeedbackSearchTxb.Text);
        }

        private void LoadSupportData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = "SELECT TicketId, Category, ContactInfo, [Message], IsResponded, DateSubmitted FROM TechSupport ORDER BY DateSubmitted DESC";
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    supportTable = new DataTable();
                    adapter.Fill(supportTable);
                    SupportDGV.DataSource = supportTable;
                    SupportDGV.Columns["Message"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                    SupportDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (SupportDGV.Columns.Contains("TicketId"))
                        SupportDGV.Columns["TicketId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    if (SupportDGV.Columns.Contains("IsResponded"))
                        SupportDGV.Columns["IsResponded"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    if (!SupportDGV.Columns.Contains("btnDelete"))
                    {
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        btn.HeaderText = "Action";
                        btn.Text = "PURGE";
                        btn.Name = "btnDelete";
                        btn.UseColumnTextForButtonValue = true;
                        SupportDGV.Columns.Add(btn);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SUPPORT ERROR: Check if 'IsResponded' or 'DateSubmitted' exist in TechSupport.\n\nDetails: " + ex.Message);
                }
            }
        }

        private DataTable allAccountsTable;
        private void LoadAllAccounts()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                string query = "SELECT UserID, UserName, Email, Age, DOB, CharacterGender, TotalXP FROM UserAccounts";
                try
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    allAccountsTable = new DataTable();
                    adapter.Fill(allAccountsTable);

                    AccountsDGV.DataSource = null;
                    AccountsDGV.DataSource = allAccountsTable;

                    AccountsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    ResetPasswordButton.Enabled = false;
                    ResetPasswordButton.Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("ACCOUNT_LOAD_ERROR: " + ex.Message); }
            }
        }
        private void SupportSearchTxb_TextChanged(object sender, EventArgs e)
        {
            if (supportTable == null) return;
            supportTable.DefaultView.RowFilter = string.Format("Category LIKE '%{0}%' OR ContactInfo LIKE '%{0}%' OR Message LIKE '%{0}%'", SupportSearchTxb.Text);
        }

        private void SupportDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex].Name == "IsResponded")
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);

                bool newValue = Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["IsResponded"].Value);
                int ticketID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["TicketId"].Value);

                string dbVal = newValue ? "True" : "False";
                ExecuteNonQuery($"UPDATE TechSupport SET IsResponded = {dbVal} WHERE TicketId = {ticketID}");

            }

            if (dgv.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int ticketID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["TicketId"].Value);

                DialogResult confirm = MessageBox.Show("Purge this ticket node?", "SYSTEM OVERWRITE",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    ExecuteNonQuery($"DELETE FROM TechSupport WHERE TicketId = {ticketID}");
                    LoadSupportData();
                }
            }
        }

        private void AccountSearchTxb_TextChanged(object sender, EventArgs e)
        {
            if (allAccountsTable == null) return;
            allAccountsTable.DefaultView.RowFilter = string.Format("UserName LIKE '%{0}%' OR Email LIKE '%{0}%'", AccountSearchTxb.Text);
        }
        private void AccountsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (AccountsDGV.SelectedRows.Count > 0)
            {
                ResetPasswordButton.Visible = true;
                ResetPasswordButton.Enabled = true;
            }
            else
            {
                ResetPasswordButton.Visible = false;
                ResetPasswordButton.Enabled = false;
            }
        }
        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            if (AccountsDGV.SelectedRows.Count == 0) return;

            DataGridViewRow row = AccountsDGV.SelectedRows[0];
            int userId = Convert.ToInt32(row.Cells["UserID"].Value);
            string username = row.Cells["UserName"].Value.ToString();

            string newPassTemplate = char.ToUpper(username[0]) + username.Substring(1).ToLower() + "123!";

            DialogResult confirm = MessageBox.Show($"Reset password for {username}?\nNew password will be: {newPassTemplate}",
                                                  "PROTOCOL OVERRIDE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                if (helper.ResetUserPassword(userId, username))
                {
                    AudioManager.PlayClick();
                    MessageBox.Show($"Access restored. User can now login with: {newPassTemplate}", "RESTORE SUCCESS");
                }
            }
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
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void ExecuteNonQuery(string sql)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void FeedbackWrapChk_CheckedChanged(object sender, EventArgs e)
        {
            if (FeedbackWarpChk.Checked)
            {
                FeedbackDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                FeedbackDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                foreach (DataGridViewRow row in FeedbackDGV.Rows) row.Height = 22;
            }
        }

        private void SupportWrapChk_CheckedChanged(object sender, EventArgs e)
        {
            if (SupportWarpChk.Checked)
            {
                SupportDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                SupportDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                foreach (DataGridViewRow row in SupportDGV.Rows) row.Height = 22;
            }
        }

        private async void ReturnToMMenuButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Form nextScreen = authenticatedUser.IsAdmin ? Program.GlobalAdminMainMenu : Program.GlobalMainMenu;
            nextScreen.Bounds = this.DesktopBounds;
            nextScreen.Show();
            this.Hide();
        }

    }
}