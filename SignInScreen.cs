using Cyber_DefenderTCG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media;

namespace Cyber_DefenderTCG
{
    public partial class SignInScreen : Form
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
        private string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppDomain.CurrentDomain.BaseDirectory}CyberDefenderDatabase.accdb;Persist Security Info=False;";
        Helper helper = new Helper();
        public SignInScreen(Rectangle previousBounds)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = previousBounds;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

        }

        private async void CreateAccountButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();
            Rectangle currentBounds = this.DesktopBounds;
            var nextScreen = Program.GlobalSignUp;
            nextScreen.Bounds = currentBounds;
            nextScreen.Show();
            nextScreen.Icon = this.Icon;
            nextScreen.Refresh();
            await Task.Delay(100);
            this.Hide();
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
        private async void LoginAccountButton_Click(object sender, EventArgs e)
        {
            AudioManager.PlayClick();

            if (EmailTxb.Text == null || PasswordTxb.Text == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!EmailTxb.Text.Contains("@") || !EmailTxb.Text.Contains(".") || EmailTxb.Text.Contains("@.") || EmailTxb.Text.Contains(".@") || EmailTxb.Text.Contains(" ") || EmailTxb.Text.StartsWith("@") || EmailTxb.Text.EndsWith("@") || EmailTxb.Text.StartsWith(".") || EmailTxb.Text.EndsWith("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (PasswordTxb.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }
            else if (!helper.HasUpperCase(PasswordTxb.Text) || !helper.HasDigit(PasswordTxb.Text) || !helper.HasCharacters(PasswordTxb.Text))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one digit, and one special character.");
                return;
            }

            string email = EmailTxb.Text;
            string authenticateQuery = "SELECT UserID, UserName, Email, Password, CharacterGender, TotalXP, IsAdmin FROM UserAccounts WHERE Email = @email";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(authenticateQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    try
                    {
                        connection.Open();
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader["Password"].ToString();

                                if (BCrypt.Net.BCrypt.Verify(PasswordTxb.Text, storedHashedPassword))
                                {
                                    User activeUser = new User
                                    {
                                        UserID = (int)reader["UserID"],
                                        Username = reader["UserName"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        Gender = reader["CharacterGender"].ToString(),
                                        XP = reader["TotalXP"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TotalXP"]),
                                        IsAdmin = reader["IsAdmin"] != DBNull.Value && Convert.ToBoolean(reader["IsAdmin"])
                                    };

                                    if (activeUser.IsAdmin)
                                    {
                                        Program.GlobalAdminLoading = new AdminLoadingScreen(this.DesktopBounds, activeUser);
                                        Program.GlobalAdminLoading.Show();
                                        Program.GlobalAdminLoading.Icon = this.Icon;
                                    }
                                    else
                                    {
                                        Program.GlobalLoading = new LoadingScreen(this.DesktopBounds, activeUser);
                                        Program.GlobalLoading.Show();
                                        Program.GlobalLoading.Icon = this.Icon;
                                    }

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid email or password.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);

                    }
                }
            }
        }

        private void EmailTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                PasswordTxb.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void PasswordTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Enter))
            {
                LoginAccountButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

      
    }
}
