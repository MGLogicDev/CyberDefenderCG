using Cyber_DefenderTCG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cyber_DefenderTCG
{
    public partial class MainMenuScreen : Form
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
        public User authenticatedUser;
        Icon appIcon = Properties.Resources.CyberDefenderIcon;
        public MainMenuScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            Icon = appIcon;
            this.Icon = appIcon;


            CurrentUserLabel.Text = $"Welcome, {authenticatedUser.Username}!";
            Rank.Text = $"{authenticatedUser.GetRankTitle()}";
            label1.Visible = false;
            tableLayoutPanel6.Visible = false;
            EasyButton.Visible = false;
            EasyButton.Enabled = false;
            MediumButton.Visible = false;
            MediumButton.Enabled = false;
            HardButton.Visible = false;
            HardButton.Enabled = false;
            EndlessButton.Visible = false;
            EndlessButton.Enabled = false;

            switch (authenticatedUser.GetRankTitle().ToLower())
            {
                case "script kiddie":
                    RankPbox.Image = Properties.Resources.ScriptKiddie;
                    break;
                case "system drifter":
                    RankPbox.Image = Properties.Resources.SystemDrifter;
                    break;
                case "data freelancer":
                    RankPbox.Image = Properties.Resources.DataFreelancer;
                    break;
                case "cyber sentinel":
                    RankPbox.Image = Properties.Resources.CyberSentinel;
                    break;
                case "netrunner":
                    RankPbox.Image = Properties.Resources.Netrunner;
                    break;
                case "grand architect":
                    RankPbox.Image = Properties.Resources.GrandArchitect;
                    break;
            }

            if (authenticatedUser.Gender?.Trim().ToLower() == "male")
            {
                Character.Image = Properties.Resources.male;
            }
            else if (authenticatedUser.Gender?.Trim().ToLower() == "female")
            {
                Character.Image = Properties.Resources.female;
            }
            else
            {
                Character.Image = Properties.Resources.CyberDefenderIiconImage_png;
            }

        }

        private void SettingsPB_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();

            using (SettingsScreen settings = new SettingsScreen(authenticatedUser))
            {

                DialogResult result = settings.ShowDialog();

                if (result == DialogResult.Abort)
                {

                    AudioManager.StopBGMusic();
                    Program.GlobalMainMenu.Close();
                    
                }
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            label1.Visible = true;
            tableLayoutPanel6.Visible = true;
            EasyButton.Visible = true;
            EasyButton.Enabled = true;
            MediumButton.Visible = true;
            MediumButton.Enabled = true;
            HardButton.Visible = true;
            HardButton.Enabled = true;
            EndlessButton.Visible = true;
            EndlessButton.Enabled = true;
        }


        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {

            label1.Visible = false;
            tableLayoutPanel6.Visible = false;
            EasyButton.Visible = false;
            EasyButton.Enabled = false;
            MediumButton.Visible = false;
            MediumButton.Enabled = false;
            HardButton.Visible = false;
            HardButton.Enabled = false;
            EndlessButton.Visible = false;
            EndlessButton.Enabled = false;

        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            EasyGameScreen easyGameScreen = new EasyGameScreen(currentBounds, authenticatedUser);
            easyGameScreen.Show();
            easyGameScreen.Icon = appIcon;
            this.Hide();
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            MediumGameplayScreen mediumGameScreen = new MediumGameplayScreen(currentBounds, authenticatedUser);
            mediumGameScreen.Show();
            mediumGameScreen.Icon = appIcon;
            this.Hide();
        }


        private void HardButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            HardGameplayScreen hardGameScreen = new HardGameplayScreen(currentBounds, authenticatedUser);
            hardGameScreen.Show();
            hardGameScreen.Icon = appIcon;
            this.Hide();

        }

        private async void NotesButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalNotes;
            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
        }

        private async void CardsButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalCards;
            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
        }

        private async void StatisticsButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalStatistics;
            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
        }

        private void SaveExitButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayCancel();
            Application.Exit();

        }

        private void EndlessButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            EndlessGameScreen endlessGameScreen = new EndlessGameScreen(currentBounds, authenticatedUser);
            endlessGameScreen.Show();
            endlessGameScreen.Icon = appIcon;
            this.Hide();
        }

        
        private async void ProfileButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            using (ProfileScreen profile = new ProfileScreen(this.DesktopBounds, authenticatedUser))
            {
                if (profile.ShowDialog() == DialogResult.OK)
                {
                    CurrentUserLabel.Text = $"Welcome, {authenticatedUser.Username}!";
                    UpdateCharacterImage();
                }
            }
        }

        private void UpdateCharacterImage()
        {
            if (authenticatedUser.Gender?.Trim().ToLower() == "male")
                Character.Image = Properties.Resources.male;
            else if (authenticatedUser.Gender?.Trim().ToLower() == "female")
                Character.Image = Properties.Resources.female;
            else
                Character.Image = Properties.Resources.CyberDefenderIiconImage_png;
        }
    }
}
