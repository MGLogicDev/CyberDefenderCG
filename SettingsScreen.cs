using Cyber_DefenderTCG.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cyber_DefenderTCG
{
    public partial class SettingsScreen : Form
    {
        User authenticatedUser;
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

        public SettingsScreen(User user)
        {
            InitializeComponent();
            MasterTrackBar.Value = (int)(AudioManager.MasterVolume * 100);
            MusicTrackBar.Value = (int)(AudioManager.BGMVolume * 100);
            this.authenticatedUser = user;
            this.Icon = Properties.Resources.CyberDefenderIcon;

            if(authenticatedUser.IsAdmin == true)
            {
                TutorialButton.Visible = false;
            }
             else if (authenticatedUser.IsAdmin == false)
            {
                TutorialButton.Visible = true;
                
            }
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            var page = new TaskDialogPage()
            {
                Caption = "Cyber Defender Command Center",
                Heading = "Tech Support Request",
                Text = "Select the category that best describes your issue:",
                Buttons = { TaskDialogButton.Cancel }
            };

            var catPassword = page.RadioButtons.Add("Forgot Password");
            var catEmail = page.RadioButtons.Add("Forgot Email");
            var catBug = page.RadioButtons.Add("Report Bug / Issue");
            var catOther = page.RadioButtons.Add("Other Technical Help");

            var btnSubmit = new TaskDialogCommandLinkButton("Submit Support Ticket", "You will be asked for your contact info and issue details.");
            page.Buttons.Add(btnSubmit);

            var result = TaskDialog.ShowDialog(this, page);

            if (result == btnSubmit)
            {
                string category = page.RadioButtons.FirstOrDefault(r => r.Checked)?.Text ?? "General Help";

                string email = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter your email address so the Admin can contact you:",
                    "Contact Information", "");

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Contact information is required to submit a ticket.");
                    return;
                }

                string message = Microsoft.VisualBasic.Interaction.InputBox(
                    "Describe your issue or suggestion in detail:",
                    "Message Details", "");

                if (!string.IsNullOrWhiteSpace(message))
                {
                    helper.SaveSupportTicket(category, email, message);

                    MessageBox.Show("Support ticket transmitted successfully. The Admin will review your request and respond within 24 hours.", "Transmission Successful");
                }
                else
                {
                    MessageBox.Show("Message cannot be empty.");
                }
            }
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Icon appIcon = this.Icon;
            AudioManager.PlayCancel();
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "System Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AudioManager.PlayCancel();
                Program.GlobalLogin.Show();
                Program.GlobalLogin.Icon = appIcon;

                if (authenticatedUser.IsAdmin == true)
                {
                    AudioManager.StopBGMusic();
                    Program.GlobalAdminLoading.Close();
                    Program.GlobalAnalytics.Close();
                    Program.GlobalCards.Close();
                    Program.GlobalReviews.Close();
                    this.Close();
                    Program.GlobalAdminMainMenu.Close();

                }
                else 
                {
                    AudioManager.StopBGMusic();
                    Program.GlobalLoading.Close();
                    Program.GlobalNotes.Close();
                    Program.GlobalCards.Close();
                    Program.GlobalProfile.Close();
                    Program.GlobalStatistics.Close();
                    Program.GlobalTutorial.Close();
                    this.Close();
                    Program.GlobalMainMenu.Close();

                }


            }
        }
        private void RateGameButton_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            AudioManager.PlayClick();
            helper.PromptGameRating(this, authenticatedUser);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MasterTrackBar_Scroll(object sender)
        {
            AudioManager.MasterVolume = MasterTrackBar.Value / 100.0;
        }

        private void MusicTrackBar_Scroll_1(object sender)
        {
            AudioManager.BGMVolume = MusicTrackBar.Value / 100.0;
        }

        private async void TutorialButton_Click(object sender, EventArgs e)
        {
            if (authenticatedUser.IsAdmin == false)
            {
                AudioManager.PlayClick();
                Rectangle currentBounds = this.DesktopBounds;
                var nextScreen = Program.GlobalTutorial;
                nextScreen.Show();
                nextScreen.Icon = this.Icon;
                nextScreen.Refresh();
                await Task.Delay(100);
                this.Hide();
                Program.GlobalMainMenu.Hide();
            }
            else
            {
                AudioManager.PlayClick();
            }
        }
    }
}