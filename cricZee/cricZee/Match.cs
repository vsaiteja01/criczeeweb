using System;
using System.Collections.Generic;

#nullable disable

namespace cricZee
{
    public partial class Match
    {
        public string Id { get; set; }
        public string Season { get; set; }
        public string City { get; set; }
        public string Date { get; set; }
        public string Team1Picture { get; set; }
        public string Team1 { get; set; }
        public string Team2Picture { get; set; }
        public string Team2 { get; set; }
        public string TossWinner { get; set; }
        public string TossDecision { get; set; }
        public string Result { get; set; }
        public string DlApplied { get; set; }
        public string Winner { get; set; }
        public string WinByRuns { get; set; }
        public string WinByWickets { get; set; }
        public string PlayerOfMatch { get; set; }
        public string Venue { get; set; }
        public string Umpire1 { get; set; }
        public string Umpire2 { get; set; }
        public string Umpire3 { get; set; }
    }
}
