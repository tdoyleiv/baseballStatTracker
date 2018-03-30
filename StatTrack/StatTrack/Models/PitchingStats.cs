using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class PitchingStats
    {
        public int PitchingStatsID { get; set; }
        public virtual Team Team { get; set; }
        public int TeamID { get; set; }
        public virtual Player Player { get; set; }
        public int PlayerID { get; set; }
        public int G { get; set; }
        public float IP { get; set; }
        public int H { get; set; }
        public int R { get; set; }
        public int ER { get; set; }
        public int BB { get; set; }
        public int K { get; set; }
        public float ERA { get; set; }
        public int W { get; set; }
        public int L { get; set; }
        public int SV { get; set; }
        public float AVG { get; set; }
        public float WHIP { get; set; }
        public int PC { get; set; }
        public int S { get; set; }
        public int B { get; set; }
        public int GB { get; set; }
        public int FB { get; set; }
    }
}