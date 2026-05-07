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
    public partial class NotesScreen : Form
    {
        private string connString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppDomain.CurrentDomain.BaseDirectory}CyberDefenderDatabase.accdb;Persist Security Info=False;";
        private User authenticatedUser;
        private int? selectedNotesID = null;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public NotesScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            NotesTextBox.Visible = false;
            NotesTextBox.Enabled = false;
            SaveButton.Visible = false;
            SaveButton.Enabled = false;
            label2.Enabled = false;
            label2.Visible = false;

            _ = LoadNotesForUser();
        }

        private async Task LoadNotesForUser()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string query = "SELECT NotesID, Notes, DateCreated FROM StudyNotes WHERE UserID = ? ORDER BY DateCreated DESC";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", authenticatedUser.UserID);

                    await conn.OpenAsync();
                    DataTable dt = new DataTable();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }
                    NotesGrid.DataSource = dt;
                    NotesGrid.Refresh();


                    if (NotesGrid.Columns.Contains("NotesID"))
                        NotesGrid.Columns["NotesID"].Visible = false;

                    if (NotesGrid.Columns.Contains("Notes"))
                        NotesGrid.Columns["Notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    NotesGrid.ClearSelection();
                }
            }
            catch (Exception ex) { MessageBox.Show("Load Error: " + ex.Message); }
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


        private void AddButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            selectedNotesID = null;
            NotesTextBox.Clear();
            ToggleEditMode(true);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NotesGrid.SelectedRows.Count > 0)
            {
                AudioManager.PlayClick();
                selectedNotesID = Convert.ToInt32(NotesGrid.SelectedRows[0].Cells["NotesID"].Value);
                NotesTextBox.Text = NotesGrid.SelectedRows[0].Cells["Notes"].Value.ToString();
                ToggleEditMode(true);
            }
            else
            {
                MessageBox.Show("Please select a note to edit.");
            }
        }

        private void ToggleEditMode(bool isEditing)
        {
            NotesTextBox.Visible = isEditing;
            NotesTextBox.Enabled = isEditing;
            SaveButton.Visible = isEditing;
            SaveButton.Enabled = isEditing;
            label2.Enabled = isEditing;
            label2.Visible = isEditing;
            AddButton.Enabled = !isEditing;
            AddButton.Visible = !isEditing;
            EditButton.Enabled = !isEditing;
            EditButton.Visible = !isEditing;
            DeleteButton.Enabled = !isEditing;
            DeleteButton.Visible = !isEditing;
        }


        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NotesGrid.SelectedRows.Count == 0) return;

            var confirm = MessageBox.Show("Permanently delete this note?", "Security Warning", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            AudioManager.PlayCancel();
            int idToDelete = Convert.ToInt32(NotesGrid.SelectedRows[0].Cells["NotesID"].Value);

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string query = "DELETE FROM StudyNotes WHERE NotesID = @nid";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nid", idToDelete);

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
                await LoadNotesForUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NotesTextBox.Text)) return;

            AudioManager.PlayClick();

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string query;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;

                    if (selectedNotesID == null)
                    {
                        query = "INSERT INTO StudyNotes (UserID, Notes, DateCreated) VALUES (?, ?, ?)";
                        cmd.Parameters.Add("@uid", OleDbType.Integer).Value = authenticatedUser.UserID;
                        cmd.Parameters.Add("@txt", OleDbType.LongVarWChar).Value = NotesTextBox.Text;
                        cmd.Parameters.Add("@date", OleDbType.Date).Value = DateTime.Now;
                    }
                    else
                    {
                        query = "UPDATE StudyNotes SET Notes = ? WHERE NotesID = ?";
                        cmd.Parameters.Add("@txt", OleDbType.LongVarWChar).Value = NotesTextBox.Text;
                        cmd.Parameters.Add("@nid", OleDbType.Integer).Value = selectedNotesID;
                    }

                    cmd.CommandText = query;
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

                ToggleEditMode(false);
                await LoadNotesForUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Error: " + ex.Message);
            }
        }



        private void RefreshButton_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Refresh page";
        }

        private void RefreshButton_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Add new note";
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void EditButton_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "select note in list to edit";
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void DeleteButton_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "select note in list to delete";
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
