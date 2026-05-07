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
    public partial class ProfileScreen : Form
    {
        private User authenticatedUser;
        private Helper helper = new Helper();
        string placeholderPassword = "********";

        public ProfileScreen(Rectangle previousBounds, User user)
        {
            InitializeComponent();
            this.authenticatedUser = user;
            this.Bounds = previousBounds;
            this.StartPosition = FormStartPosition.Manual;

            if (GenderCmb.Items.Count == 0)
            {
                GenderCmb.Items.Add("Male");
                GenderCmb.Items.Add("Female");
            }

            UsernameTxb.Text = authenticatedUser.Username;

            EmailTxb.Text = authenticatedUser.Email;

            PasswordTxb.Text = placeholderPassword;

            string userGender = authenticatedUser.Gender?.Trim();
            if (!string.IsNullOrEmpty(userGender))
            {
                int index = GenderCmb.FindStringExact(userGender);
                if (index != -1) GenderCmb.SelectedIndex = index;
                else GenderCmb.Text = userGender;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();

            if (string.IsNullOrWhiteSpace(UsernameTxb.Text) || string.IsNullOrWhiteSpace(EmailTxb.Text))
            {
                MessageBox.Show("Username and Email are required for synchronization.");
                return;
            }

            bool passwordWasChanged = PasswordTxb.Text != placeholderPassword;

            if (passwordWasChanged)
            {
                if (PasswordTxb.Text.Length < 8 || !helper.HasUpperCase(PasswordTxb.Text) || !helper.HasDigit(PasswordTxb.Text))
                {
                    MessageBox.Show("New password does not meet security protocols (8+ chars, Uppercase, and Digit required).");
                    return;
                }
            }

            if (helper.UpdateUserProfile(authenticatedUser.UserID, UsernameTxb.Text, EmailTxb.Text, PasswordTxb.Text, GenderCmb.Text, passwordWasChanged))
            {
                authenticatedUser.Username = UsernameTxb.Text;
                authenticatedUser.Email = EmailTxb.Text;
                authenticatedUser.Gender = GenderCmb.Text;

                MessageBox.Show("Identity synchronized successfully.", "UPLINK SUCCESS");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayCancel();
            var result = MessageBox.Show("WARNING: This will permanently purge your account from the mainframe. Continue?",
                                         "CRITICAL ACTION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (helper.DeleteUserAccount(authenticatedUser.UserID))
                {
                    MessageBox.Show("Account purged. System restarting...", "DE-AUTHORIZED");
                    Application.Restart();
                }
            }
        }

        private async void ReturnToMMenuButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Form nextScreen = Program.GlobalMainMenu;
            nextScreen.Bounds = this.DesktopBounds;
            nextScreen.Show();
            this.Hide();
        }


    }
}
