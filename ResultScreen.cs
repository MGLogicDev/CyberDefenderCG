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
    public partial class ResultScreen : Form
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
        private int currentMatchID;
        internal ResultScreen(Rectangle previousBounds, GameEngine gameEngine, bool victory)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.authenticatedUser = gameEngine.CurrentUser;
            this.currentMatchID = gameEngine.MatchID;

            authenticatedUser = gameEngine.CurrentUser;
            if (victory == true)
            {
                MatchResultLabel.Text = "Victory!";
                MatchResultLabel.ForeColor = Color.Green;
                AudioManager.PlayVictory();
            }
            else
            {
                MatchResultLabel.Text = "Defeat!";
                MatchResultLabel.ForeColor = Color.Red;
                AudioManager.PlayGameOver();
            }

            int xpFromAnswers = gameEngine.CorrectCount * 10;
            int victoryBonus = victory ? 50 : 0;
            int totalXPGained = xpFromAnswers + victoryBonus;

            MatchDifficultyLabel.Text = gameEngine.selectedDifficulty;
            UsernameLabel.Text = gameEngine.CurrentUser.Username;
            MatchIDLabel.Text = gameEngine.MatchID.ToString();
            ThreatsNeutralizedLabel.Text = gameEngine.CorrectCount.ToString();
            SecurityBreachLabel.Text = gameEngine.WrongCount.ToString();
            HealthRemainedLabel.Text = $"{gameEngine.Health}%";
            DatePlayedLabel.Text = DateTime.Now.ToString("g");
            
            XPGainedLabel.Text = $"{totalXPGained} XP";
            authenticatedUser.XP += totalXPGained; 
            CurrentRankLabel.Text = authenticatedUser.GetRankTitle();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Helper helper = new Helper();
            int rating;
            if(Rating5.Checked)
            {
                rating = 5;
                Rating1.Checked = false;
                Rating2.Checked = false;
                Rating3.Checked = false;
                Rating4.Checked = false;
            }
            else if(Rating4.Checked)
            {
                rating = 4;
                Rating1.Checked = false;
                Rating2.Checked = false;
                Rating3.Checked = false;
                Rating5.Checked = false;
            }
            else if(Rating3.Checked)
            {
                rating = 3;
                Rating1.Checked = false;
                Rating2.Checked = false;
                Rating4.Checked = false;
                Rating5.Checked = false;

            }
            else if(Rating2.Checked)
            {
                rating = 2;
                Rating1.Checked = false;
                Rating3.Checked = false;
                Rating4.Checked = false;
                Rating5.Checked = false;
            }
            else if(Rating1.Checked)
            {
                rating = 1;
                Rating2.Checked = false;
                Rating3.Checked = false;
                Rating4.Checked = false;
                Rating5.Checked = false;
            }
            else
            {
                rating = 0;
                Rating1.Checked = false;
                Rating2.Checked = false;
                Rating3.Checked = false;
                Rating4.Checked = false;
                Rating5.Checked = false;
            }

            string feedback = SuggestionTxb.Text;

            if (rating > 0)
            {
                helper.SaveMatchFeedback(currentMatchID, authenticatedUser.UserID, rating, feedback);
            }
            
            Rectangle currentBounds = this.DesktopBounds;

            if (authenticatedUser != null && authenticatedUser.IsAdmin)
            {
                var nextScreen = Program.GlobalAdminMainMenu;
                nextScreen.Bounds = currentBounds;
                nextScreen.StartPosition = FormStartPosition.Manual;
                nextScreen.Show();
                nextScreen.Icon = this.Icon;
                nextScreen.Refresh();
            }
            else
            {
                var nextScreen = Program.GlobalMainMenu;
                nextScreen.Bounds = currentBounds;
                nextScreen.StartPosition = FormStartPosition.Manual;
                nextScreen.Show();
                nextScreen.Icon = this.Icon;
                nextScreen.Refresh();
            }

            await Task.Delay(100);
            this.Hide();
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ResultOKButton.PerformClick();
            }
        }
        public void SetForfeit()
        {
            MatchResultLabel.Text = "Forfeited";
            MatchResultLabel.ForeColor = Color.Red;
            HealthRemainedLabel.Text = "N/A";
            DatePlayedLabel.Text = DateTime.Now.ToString("g");
            CurrentRankLabel.Text = authenticatedUser.GetRankTitle();
            XPGainedLabel.Text = "0 XP";
        }
    }
}
