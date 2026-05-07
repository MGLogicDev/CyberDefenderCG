using Cyber_DefenderTCG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cyber_DefenderTCG
{
    public partial class AdminLoadingScreen : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private User authenticatedUser;

        public AdminLoadingScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private async void LoadingScreen_Load(object sender, EventArgs e)
        {
            try
            {

                Icon appIcon = Properties.Resources.CyberDefenderIcon;

                await AnimateProgress(20, "Loading Audio Assets...");
                AudioManager.LoadAllSounds();
                AudioManager.PlayBGMusic();

                await AnimateProgress(40, "Building Menu...");
                Program.GlobalAdminMainMenu = new AdminMainMenu(this.DesktopBounds, authenticatedUser);
                Program.GlobalAdminMainMenu.Icon = appIcon;
                _ = Program.GlobalAdminMainMenu.Handle; 

                await AnimateProgress(60, "Loading Analytics...");
                Program.GlobalAnalytics = new AnalyticsScreen(this.DesktopBounds, authenticatedUser);
                Program.GlobalAnalytics.Icon = appIcon;
                _ = Program.GlobalAnalytics.Handle;

                await AnimateProgress(65, "Loading Cards...");
                Program.GlobalCards = new CardsScreen(this.DesktopBounds, authenticatedUser);
                Program.GlobalCards.Icon = appIcon;
                _ = Program.GlobalCards.Handle;

                await AnimateProgress(70, "Loading Reviews...");
                Program.GlobalReviews = new ReviewsScreen(this.DesktopBounds, authenticatedUser);
                Program.GlobalReviews.Icon = appIcon;
                _ = Program.GlobalReviews.Handle;

                await AnimateProgress(80, "Finalizing...");
                Program.GlobalSettings = new SettingsScreen(authenticatedUser);
                Program.GlobalSettings.Icon = appIcon;
                _ = Program.GlobalSettings.Handle;

                await AnimateProgress(100, "Welcome Admin " + authenticatedUser.Username);
                await Task.Delay(500);

                Program.GlobalAdminMainMenu.Show();
                Program.GlobalAdminMainMenu.Icon = appIcon;
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during loading: " + ex.Message, "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task AnimateProgress(int targetValue, string status, int speed = 15)
        {
            StatusLabel.Text = status;

            while (LoadingPBar.ValueNumber < targetValue)
            {

                LoadingPBar.ValueNumber++;
                await Task.Delay(speed);
            }
        }
    }
}

