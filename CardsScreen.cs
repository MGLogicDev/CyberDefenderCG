using Cyber_DefenderTCG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cyber_DefenderTCG
{
    public partial class CardsScreen : Form
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

        private async Task LoadCards(string type)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    string query = "SELECT CardID, CardName, CardType, Description, ImageKey, Story FROM Cards WHERE CardType = @type";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@type", type);

                    await conn.OpenAsync();
                    DataTable dt = new DataTable();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }

                    CardsGridView.DataSource = dt;

                    if (CardsGridView.Columns.Contains("CardID")) CardsGridView.Columns["CardID"].Visible = false;
                    if (CardsGridView.Columns.Contains("CardType")) CardsGridView.Columns["CardType"].Visible = false;
                    if (CardsGridView.Columns.Contains("Description")) CardsGridView.Columns["Description"].Visible = false;
                    if (CardsGridView.Columns.Contains("ImageKey")) CardsGridView.Columns["ImageKey"].Visible = false;
                    if (CardsGridView.Columns.Contains("Story")) CardsGridView.Columns["Story"].Visible = false;

                    if (CardsGridView.Columns.Contains("CardName"))
                    {
                        CardsGridView.Columns["CardName"].Visible = true;
                        CardsGridView.Columns["CardName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        CardsGridView.Columns["CardName"].HeaderText = $"{type} Cards";
                    }

                    CardsGridView.ClearSelection();
                }
            }
            catch (Exception ex) { MessageBox.Show("Load Error: " + ex.Message); }
        }


        public CardsScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            CardsGridView.SelectionChanged += CardsGridView_SelectionChanged;
            this.Shown += async (s, e) => await LoadCards("Threat"); 
        }
        private void CardsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CardsGridView.SelectedRows.Count == 0) return;

            DataGridViewRow row = CardsGridView.SelectedRows[0];
            if (row.IsNewRow) return;

            object nameVal = row.Cells["CardName"].Value;
            object descVal = row.Cells["Description"].Value;
            object imgVal  = row.Cells["ImageKey"].Value;
           

            CardNameLabel.Text = (nameVal == null || nameVal == DBNull.Value) ? string.Empty : nameVal.ToString();
            DescrptionLabel.Text = (descVal == null || descVal == DBNull.Value) ? string.Empty : descVal.ToString();

            string imgKey = (imgVal == null || imgVal == DBNull.Value) ? null : imgVal.ToString();
            object resource = imgKey != null ? Properties.Resources.ResourceManager.GetObject(imgKey) : null;

            CardPbox.Image = resource as Image ?? Properties.Resources.CyberDefenderIiconImage_png;
        }

        private async void ReturnToMMenuButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            Form nextScreen = null;

            if (authenticatedUser != null && authenticatedUser.IsAdmin)
            {
                nextScreen = Program.GlobalAdminMainMenu;
            }
            else
            {
                nextScreen = Program.GlobalMainMenu;
            }


            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();

            await Task.Delay(100);
            this.Hide();
        }
        private async void ShowThreatsButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            tableLayoutPanel5.BackgroundImage = Properties.Resources.ThreatCardbg;
            tableLayoutPanel5.BackColor = Color.FromArgb(255, 49, 49);
            await LoadCards("Threat");
        }

        private async void ShowDefenseButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            tableLayoutPanel5.BackgroundImage = Properties.Resources.DefenseCardbg;
            tableLayoutPanel5.BackColor = Color.Transparent;
            await LoadCards("Defense");
        }
    }
}
