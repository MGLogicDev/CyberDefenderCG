using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using BCrypt.Net;
using System.Drawing.Text;
using Cyber_DefenderTCG.Classes;
using System.Media;
using System.Threading.Tasks;

namespace Cyber_DefenderTCG
{
    public partial class SignUpScreen : Form
    {
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
        private string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppDomain.CurrentDomain.BaseDirectory}CyberDefenderDatabase.accdb;Persist Security Info=False;";
        public SignUpScreen(Rectangle previousBounds)
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
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

        private async void CreateAccountButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();

            try
            {

                if (UsernameTxb.Text == null || EmailTxb.Text == null || PasswordTxb.Text == null || ConfirmPasswordTxb.Text == null || int.Parse(AgeUD.Value.ToString()) <= 0)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (UsernameTxb.Text.Length < 3 || UsernameTxb.Text.Length > 20)
                {
                    MessageBox.Show("Username must be between 3 and 20 characters long.");
                    return;
                }
                else if (UsernameTxb.Text.Contains(" "))
                {
                    MessageBox.Show("Username cannot contain spaces.");
                    return;
                }
                else if (UsernameTxb.Text.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=', '{', '}', '[', ']', '|', '\\', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/' }) >= 0)
                {
                    MessageBox.Show("Username cannot contain special characters.");
                    return;
                }
                else if (UsernameTxb.Text.StartsWith(" ") || UsernameTxb.Text.EndsWith(" "))
                {
                    MessageBox.Show("Username cannot start or end with a space.");
                    return;
                }


                if (!EmailTxb.Text.Contains("@") || !EmailTxb.Text.Contains(".") || EmailTxb.Text.Contains("@.") || EmailTxb.Text.Contains(".@") || EmailTxb.Text.Contains(" ") || EmailTxb.Text.StartsWith("@") || EmailTxb.Text.EndsWith("@") || EmailTxb.Text.StartsWith(".") || EmailTxb.Text.EndsWith("."))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                if (PasswordTxb.Text != ConfirmPasswordTxb.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                else if (PasswordTxb.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.");
                    return;
                }
                else if (!helper.HasUpperCase(PasswordTxb.Text) || !helper.HasLowerCase(PasswordTxb.Text) || !helper.HasDigit(PasswordTxb.Text) || !helper.HasCharacters(PasswordTxb.Text))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.");
                    return;
                }

                int inputAge = (int)AgeUD.Value;
                if (inputAge < 7 || inputAge > 120)
                {
                    MessageBox.Show("Invalid age. Users must be between 7 and 120 years old.");
                    return;
                }

                DateTime birthDate = BirthDTP.Value.Date;
                DateTime today = DateTime.Today;

                int actualAge = today.Year - birthDate.Year;

                if (birthDate.Date > today.AddYears(-actualAge))
                {
                    actualAge--;
                }

                if (birthDate > today)
                {
                    MessageBox.Show("Birth date cannot be in the future.");
                    return;
                }

                if (actualAge < 7)
                {
                    MessageBox.Show("Users under 7 years old require parental permission.");
                    return;
                }

                if (actualAge != inputAge)
                {
                    MessageBox.Show($"Birth date does not match the age provided. (Calculated age: {actualAge})");
                    return;
                }

                if (MaleRButton.Checked == false && FemaleRButton.Checked == false)
                {
                    MessageBox.Show("Check one of the gender options.");
                    return;
                }
                string characterGender;

                if(MaleRButton.Checked == true)
                {
                    characterGender = "male";
                }
                else
                {
                    characterGender = "female";
                }

               
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(PasswordTxb.Text);
               
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string checkUserQuery = "SELECT COUNT(*) FROM UserAccounts WHERE UserName = ? OR Email = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkUserQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("?", UsernameTxb.Text);
                        checkCmd.Parameters.AddWithValue("?", EmailTxb.Text);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username or email already exists.");
                            return;
                        }
                    }
                    string accountCreateQuery = "INSERT INTO UserAccounts (UserName, Email, [Password], Age, DOB, CharacterGender, TotalXP) VALUES (?, ?, ?, ?, ?, ?, 0)";

                    using (OleDbCommand command = new OleDbCommand(accountCreateQuery, connection))
                    {
                        command.Parameters.AddWithValue("?", UsernameTxb.Text);
                        command.Parameters.AddWithValue("?", EmailTxb.Text);
                        command.Parameters.AddWithValue("?", hashedPassword);
                        command.Parameters.AddWithValue("?", (int)AgeUD.Value);
                        command.Parameters.AddWithValue("?", BirthDTP.Value.Date);
                        command.Parameters.AddWithValue("?", characterGender);
                        command.ExecuteNonQuery();
                    }

                    OleDbCommand idCmd = new OleDbCommand("SELECT @@IDENTITY", connection);
                    int newUserId = (int)idCmd.ExecuteScalar();

                    string initStatsQuery = "INSERT INTO UserStatistics (UserID, RoundsPlayed, MasteryLevel, TimesPlayedEasy, TimesPlayedMedium, TimesPlayedHard, Win, Lose) " +
                                            "VALUES (?, 0, 'Script Kiddie', 0, 0, 0, 0, 0)";

                    using (OleDbCommand statCmd = new OleDbCommand(initStatsQuery, connection))
                    {
                        statCmd.Parameters.AddWithValue("?", newUserId);
                        statCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Rectangle currentBounds = this.DesktopBounds;
                    var nextScreen = Program.GlobalLogin;
                    nextScreen.Bounds = currentBounds;
                    nextScreen.StartPosition = FormStartPosition.Manual;
                    nextScreen.Show();
                    nextScreen.Icon = this.Icon;
                    await Task.Delay(100);
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async void ReturnButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayCancel();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalLogin;
            nextScreen.Bounds = currentBounds;
            nextScreen.StartPosition = FormStartPosition.Manual;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
        }

        private void UsernameTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EmailTxb.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void EmailTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTxb.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void PasswordTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmPasswordTxb.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void ConfirmPasswordTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgeUD.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void AgeUD_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                BirthDTP.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void BirthDTP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateAccountButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}


