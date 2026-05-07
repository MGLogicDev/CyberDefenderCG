using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace Cyber_DefenderTCG.Classes
{
    internal class GameEngine
    {
        private string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppDomain.CurrentDomain.BaseDirectory}CyberDefenderDatabase.accdb;Persist Security Info=False;";
        public string selectedDifficulty;
        public int MaximumHandSize { get; private set; }
        public ThreatCard CurrentThreat { get; private set; }
        public List<DefenseCard> CurrentHand { get; private set; }
        public int Health { get; private set; } = 100;
        public int CorrectCount { get; private set; } = 0;
        public int WrongCount { get; private set; } = 0;
        public User CurrentUser { get; private set; }
        public int TargetSuccesses { get; private set; }
        public int CurrentDamage { get; private set; }
        public int MatchID { get; set; }
        public Anomaly CurrentAnomaly { get; private set; }

        public GameEngine(User user)
        {
            this.CurrentUser = user;
        }

        public void SetDifficulty(string difficulty)
        {
            this.selectedDifficulty = difficulty;
            switch (difficulty.ToLower())
            {
                case "easy":
                    TargetSuccesses = 7;
                    CurrentDamage = 15;
                    MaximumHandSize = 3;
                    break;
                case "medium":
                    TargetSuccesses = 7;
                    CurrentDamage = 20;
                    MaximumHandSize = 4;
                    break;
                case "hard":
                    TargetSuccesses = 7;
                    CurrentDamage = 35;
                    MaximumHandSize = 5;
                    break;
                case "endless":
                    TargetSuccesses = 9999;
                    CurrentDamage = 40;
                    MaximumHandSize = 5;
                    break;
                default:
                    TargetSuccesses = 7; 
                    CurrentDamage = 30;
                    MaximumHandSize = 3;
                    break;
            }
        }

        public void RollAnomaly()
        {
            CurrentAnomaly = null;
            Random rnd = new Random();

            int chance = rnd.Next(1, 101); 
            int threshold = 0;

            if (CurrentUser != null && CurrentUser.IsAdmin)
            {
                threshold = 100;
            }
            else
            {
                switch (selectedDifficulty.ToLower())
                {
                    case "easy":
                        threshold = 5;
                        break;
                    case "medium":
                        threshold = 15;
                        break;
                    case "hard":
                    case "endless":
                        threshold = 20;
                        break;
                    default:
                        threshold = 5;
                        break;
                }
            }

            if (chance <= threshold)
            {
                LoadRandomAnomaly();
            }
        }

        private void LoadRandomAnomaly()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                   
                    string query = "SELECT TOP 1 [Name], [Description] FROM Anomalies ORDER BY Rnd(-1 * TimeValue(Now()) * AnomalyID)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CurrentAnomaly = new Anomaly
                            {
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString()
                            };
                        }
                        else
                        {
                            MessageBox.Show("Database Warning: Anomalies table is empty!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Error in Anomaly: " + ex.Message);
                }
                
            }

        }
        public void DrawHand()
        {
            CurrentHand = new List<DefenseCard>();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                string threatSql = (selectedDifficulty.ToLower() == "endless")
                    ? "SELECT TOP 1 * FROM Cards WHERE CardType='Threat' ORDER BY Rnd(-1000 * TimeValue(Now()) * CardID)"
                    : "SELECT TOP 1 * FROM Cards WHERE CardType='Threat' AND DifficultyType = @diff ORDER BY Rnd(-1000 * TimeValue(Now()) * CardID)";

                var cmdThreat = new OleDbCommand(threatSql, conn);
                if (selectedDifficulty.ToLower() != "endless")
                    cmdThreat.Parameters.AddWithValue("@diff", selectedDifficulty);

                using (var reader = cmdThreat.ExecuteReader())
                {
                    if (reader.Read()) CurrentThreat = MapToThreat(reader);
                    else return;
                }

                var cmdCorrect = new OleDbCommand("SELECT * FROM Cards WHERE CardID = @id", conn);
                cmdCorrect.Parameters.AddWithValue("@id", CurrentThreat.CounterID);
                using (var reader = cmdCorrect.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CurrentHand.Add(MapToDefense(reader));
                    }
                    else
                    {
                        MessageBox.Show($"Database Error: Counter ID {CurrentThreat.CounterID} not found!");
                    }
                }

                int wrongNeeded = MaximumHandSize - 1;
                var cmdWrong = new OleDbCommand($"SELECT TOP {wrongNeeded} * FROM Cards WHERE CardType='Defense' AND CardID <> @id ORDER BY Guid()", conn);
                cmdWrong.CommandText = $"SELECT TOP {wrongNeeded} * FROM Cards WHERE CardType='Defense' AND CardID <> @id ORDER BY Rnd(-2000 * TimeValue(Now()) * CardID)";
                cmdWrong.Parameters.AddWithValue("@id", CurrentThreat.CounterID);

                using (var reader = cmdWrong.ExecuteReader())
                {
                    while (reader.Read()) CurrentHand.Add(MapToDefense(reader));
                }
            }
            CurrentHand = CurrentHand.OrderBy(x => Guid.NewGuid()).ToList();
        }
       

        public bool VerifyChoice(DefenseCard selected)
        {
            if (selected.CardID == CurrentThreat.CounterID)
            {
                CorrectCount++;
                return true;
            }
            else
            {
                WrongCount++;
                Health -= CurrentDamage; 
                if (Health < 0) Health = 0;
                return false;
            }
        }

        private ThreatCard MapToThreat(OleDbDataReader reader) => new ThreatCard
        {
            CardID = (int)reader["CardID"],
            CardName = reader["CardName"].ToString(),
            CounterID = (int)reader["CounterID"],
            LawReference = reader["LawReference"].ToString(),
            Story = reader["Story"].ToString(),
            Description = reader["Description"].ToString(),
            ImageKey = reader["ImageKey"].ToString(),
            CounterReason = reader["CounterReason"] == DBNull.Value ? "No reason provided." : reader["CounterReason"].ToString()
        };

        private DefenseCard MapToDefense(OleDbDataReader reader) => new DefenseCard
        {
            CardID = (int)reader["CardID"],
            CardName = reader["CardName"].ToString(),
            ImageKey = reader["ImageKey"] == DBNull.Value ? null : reader["ImageKey"].ToString()
        };
        public void ModifyHealth(int amount)
        {
            Health += amount;
            if (Health > 100) Health = 100;
            if (Health < 0) Health = 0;
        }
    }
    
}
