using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class BattingStats
    {
        public int BattingStatsID { get; set; }
        public virtual Team Team { get; set; }
        public int TeamID { get; set; }
        public virtual Player Player { get; set; }
        public int PlayerID { get; set; }
        public int G { get; set; }
        public int PA { get; set; }
        public int AB { get; set; }
        public int R { get; set; }
        public int H { get; set; }
        public int RBI { get; set; }
        public int HR { get; set; }
        public int BB { get; set; }
        public int SF { get; set; }
        public int SH { get; set; }
        public int GB { get; set;  }
        public int FB { get; set; }
        public int SO { get; set; }
        public int SB { get; set; }
        public int CS { get; set; }
        public int TB { get; set; }
        public int LOB { get; set; }
        public int GIDP { get; set; }
        public int TwoOutRBI { get; set; }
        public int RLISP { get; set; }
        public float AVG { get; set; }
        public float OBP { get; set; }
        public float SLG { get; set; }
        public float OPS { get; set; }
        public float RISP { get; set; }
        public float WOBA { get; set; }
        public float SecA { get; set; }
        public float RC { get; set; }
        public float EqA { get; set; }

    }
}