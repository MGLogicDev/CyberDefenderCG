using System;
using System.Collections.Generic;
using System.Text;

namespace Cyber_DefenderTCG.Classes
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string DOB { get; set; }
        public int RoundsPlayed { get; set; }
        public string Gender { get; set; }
        public int XP { get; set; }
        public int Level => (XP / 100) + 1;
        public bool IsAdmin { get; set; }

        public string GetRankTitle()
        {
            int lvl = this.Level;
            if (lvl <= 15) return "Script Kiddie";
            if (lvl <= 30) return "System Drifter";
            if (lvl <= 50) return "Data Freelancer";
            if (lvl <= 75) return "Cyber Sentinel";
            if (lvl <= 99) return "Netrunner";
            return "Grand Architect";
        }
    }
}
