using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class BattingStats
    {
        public int StatsID { get; set; }
        public virtual Team Team { get; set; }
        public int TeamID { get; set; }
        public virtual Player Player { get; set; }
        public int PlayerID { get; set; }
        public int GamesPlayed { get; set; }
        public int PlateAppearance { get; set; }
        public int H { get; set; }
        public int W { get; set; }
        public int HR { get; set; }
        public int SO { get; set; }
        public int LineO { get; set; }
        public int FlyO { get; set; }
        public int GIDP { get; set; }
    }
}