using System;
using System.Collections.Generic;
using System.Text;

namespace Cyber_DefenderTCG.Classes
{
    internal abstract class Card
    {
        public int CardID { get; set; }
        public string CardName { get; set; }
        public string LawReference { get; set; }
        public string Description { get; set; } 
        public string ImageKey { get; set; }
    }
}
