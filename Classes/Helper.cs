using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing.Drawing2D;
using System.Text;
using System.Data.OleDb;
using System.Data;
using BCrypt.Net;

namespace Cyber_DefenderTCG.Classes
{
    internal class Helper
    {
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppDomain.CurrentDomain.BaseDirectory}CyberDefenderDatabase.accdb;Persist Security Info=False;";
        public int LatestXPGained { get; private set; }
        public static void UpdateUserStats(int userId, int xpGained, string difficulty, bool isVictory)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                string xpSql = "UPDATE UserAccounts SET TotalXP = IIF(ISNULL(TotalXP), 0, TotalXP) + ? WHERE UserID = ?";
                using (OleDbCommand cmdXp = new OleDbCommand(xpSql, conn))
                {
                    cmdXp.Parameters.AddWithValue("?", xpGained);
                    cmdXp.Parameters.AddWithValue("?", userId);
                    cmdXp.ExecuteNonQuery();
                }

                string diffColumn = "";
                switch (difficulty.ToLower())
                {
                    case "easy": diffColumn = "TimesPlayedEasy"; break;
                    case "medium": diffColumn = "TimesPlayedMedium"; break;
                    case "hard": diffColumn = "TimesPlayedHard"; break;
                    default: diffColumn = "TimesPlayedEasy"; break; 
                }
                string resultColumn = isVictory ? "Win" : "Lose";

                string statsSql = $"UPDATE UserStatistics SET " +
                                  $"RoundsPlayed = RoundsPlayed + 1, " +
                                  $"{diffColumn} = {diffColumn} + 1, " +
                                  $"{resultColumn} = {resultColumn} + 1 " +
                                  $"WHERE UserID = ?";

                using (OleDbCommand cmdStats = new OleDbCommand(statsSql, conn))
                {
                    cmdStats.Parameters.AddWithValue("?", userId);
                    cmdStats.ExecuteNonQuery();
                }
            }
        }

        public bool UpdateUserProfile(int userId, string username, string email, string newPassword, string gender, bool passwordChanged)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query;
                if (passwordChanged)
                {
                    query = "UPDATE UserAccounts SET UserName = ?, Email = ?, [Password] = ?, CharacterGender = ? WHERE UserID = ?";
                }
                else
                {
                    query = "UPDATE UserAccounts SET UserName = ?, Email = ?, CharacterGender = ? WHERE UserID = ?";
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", username);
                    cmd.Parameters.AddWithValue("?", email);

                    if (passwordChanged)
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                        cmd.Parameters.AddWithValue("?", hashedPassword);
                    }

                    cmd.Parameters.AddWithValue("?", gender);
                    cmd.Parameters.AddWithValue("?", userId);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Profile Sync Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool DeleteUserAccount(int userId)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string deleteStats = "DELETE FROM UserStatistics WHERE UserID = ?";
                string deleteAcc = "DELETE FROM UserAccounts WHERE UserID = ?";

                try
                {
                    conn.Open();
                    using (OleDbCommand cmd1 = new OleDbCommand(deleteStats, conn))
                    {
                        cmd1.Parameters.AddWithValue("?", userId);
                        cmd1.ExecuteNonQuery();
                    }
                    using (OleDbCommand cmd2 = new OleDbCommand(deleteAcc, conn))
                    {
                        cmd2.Parameters.AddWithValue("?", userId);
                        return cmd2.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("De-authorization Error: " + ex.Message);
                    return false;
                }
            }
        }
        public void PromptGameRating(Form owner, User user)
        {
            TaskDialogPage page = new TaskDialogPage()
            {
                Caption = "NEURAL FEEDBACK INTERFACE",
                Heading = "Agent Performance Evaluation",
                Text = "Transmit your evaluation of the Cyber Defender TCG simulation to the High Architect.",
                Icon = TaskDialogIcon.ShieldSuccessGreenBar,
                Buttons = { TaskDialogButton.Cancel }
            };

            var btn5 = new TaskDialogCommandLinkButton("★★★★★", "Optimal Performance");
            var btn4 = new TaskDialogCommandLinkButton("★★★★☆", "High Efficiency");
            var btn3 = new TaskDialogCommandLinkButton("★★★☆☆", "Baseline Stability");
            var btn2 = new TaskDialogCommandLinkButton("★★☆☆☆", "System Glitch");
            var btn1 = new TaskDialogCommandLinkButton("★☆☆☆☆", "Critical Failure");

            page.Buttons.Add(btn5); page.Buttons.Add(btn4); page.Buttons.Add(btn3);
            page.Buttons.Add(btn2); page.Buttons.Add(btn1);

            var result = TaskDialog.ShowDialog(owner, page);

            if (result is TaskDialogCommandLinkButton selected)
            {
                int rating = 0;
                if (selected == btn5) rating = 5;
                else if (selected == btn4) rating = 4;
                else if (selected == btn3) rating = 3;
                else if (selected == btn2) rating = 2;
                else if (selected == btn1) rating = 1;

                string suggestion = Microsoft.VisualBasic.Interaction.InputBox(
                    " Please enter your suggestions and feedback:",
                    "ENCRYPTED FEEDBACK", "");

                SaveOrUpdateGameReview(user.UserID, rating, suggestion);
                MessageBox.Show("Evaluation Saved", "PROTOCOL SUCCESS");
            }
        }
        public void SaveOrUpdateGameReview(int userId, int rating, string suggestion)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkSql = "SELECT COUNT(*) FROM GameReviews WHERE UserID = ?";
                    OleDbCommand checkCmd = new OleDbCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("?", userId);
                    int existing = (int)checkCmd.ExecuteScalar();

                    string finalSql;
                    if (existing > 0)
                    {
                        finalSql = "UPDATE GameReviews SET Rating = ?, Suggestion = ?, DateSubmitted = Now() WHERE UserID = ?";
                    }
                    else
                    {
                        finalSql = "INSERT INTO GameReviews (Rating, Suggestion, UserID, DateSubmitted) VALUES (?, ?, ?, Now())";
                    }

                    using (OleDbCommand cmd = new OleDbCommand(finalSql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", rating);
                        cmd.Parameters.AddWithValue("?", suggestion);
                        cmd.Parameters.AddWithValue("?", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Review Sync Error: " + ex.Message); }
            }
        }

        public bool UserHasNotRated(int userId)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM GameReviews WHERE UserID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", userId);
                conn.Open();
                return (int)cmd.ExecuteScalar() == 0;
            }
        }

        public void SaveSupportTicket(string category, string contactInfo, string message)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "INSERT INTO TechSupport (Category, ContactInfo, [Message], DateSubmitted) VALUES (?, ?, ?, Now())";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", category);
                    cmd.Parameters.AddWithValue("?", contactInfo);
                    cmd.Parameters.AddWithValue("?", message);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ticket Transmission Error: " + ex.Message);
                    }
                }
            }
        }

        public bool HasUpperCase(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        public bool HasLowerCase(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLower(c))
                    return true;
            }
            return false;
        }

        public bool HasDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        public bool HasCharacters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                    return true;
            }
            return false;
        }
        public int SaveMatchToDatabase(int userId, string difficulty, int correct, int wrong, int health)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string insertquery = "INSERT INTO MatchLogs (UserId, DatePlayed, Difficulty, CorrectChoices, IncorrectChoices, HealthRemaining) " +
                                     "VALUES (?, Now(), ?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(insertquery, conn);
                cmd.Parameters.AddWithValue("?", userId);
                cmd.Parameters.AddWithValue("?", difficulty);
                cmd.Parameters.AddWithValue("?", correct);
                cmd.Parameters.AddWithValue("?", wrong);
                cmd.Parameters.AddWithValue("?", health);

                conn.Open();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT @@IDENTITY";
                return (int)cmd.ExecuteScalar();
            }
        }
        public int EndGame(bool isVictory, int userId, string difficulty, int correct, int wrong, int health)
        {
            int matchId = SaveMatchToDatabase(userId, difficulty, correct, wrong, health);
            int xpGained = (correct * 10) + (isVictory ? 50 : 0);
            UpdateUserStats(userId, xpGained, difficulty, isVictory);

            return matchId;
        }
        public bool ResetUserPassword(int userId, string username)
        {
            string newPlainPassword = char.ToUpper(username[0]) + username.Substring(1).ToLower() + "123!";
            string hashedPass = BCrypt.Net.BCrypt.HashPassword(newPlainPassword);

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "UPDATE UserAccounts SET [Password] = ? WHERE UserID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", hashedPass);
                    cmd.Parameters.AddWithValue("?", userId);
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("RESET_FAILURE: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public bool IsNewAgent(int userId)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM MatchLogs WHERE UserId = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", userId);
                try
                {
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0; 
                }
                catch { return false; }
            }
        }
        public void SaveMatchFeedback(int matchId, int userId, int rating, string suggestion)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "INSERT INTO MatchFeedback (MatchID, UserID, Rating, Suggestion, DateSubmitted) " +
                               "VALUES (?, ?, ?, ?, Now())";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", matchId);
                cmd.Parameters.AddWithValue("?", userId);
                cmd.Parameters.AddWithValue("?", rating);
                cmd.Parameters.AddWithValue("?", suggestion);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Telemetry Feedback Error: " + ex.Message);
                }
            }
        }

    }
}
