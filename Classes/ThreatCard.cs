using System;
using System.Collections.Generic;
using System.Text;

namespace Cyber_DefenderTCG.Classes
{
    internal class ThreatCard: Card
    {
        public int CounterID { get; set; }
        public string Story { get; set; }
        public string CounterReason { get; set; }
    }
}
