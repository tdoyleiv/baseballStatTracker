using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class League
    {
        public int LeagueID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }

        public virtual ICollection<BattingStats> LeagueBattingStats { get; set; }
        public virtual ICollection<PitchingStats> LeaguePitchingStats { get; set; }
    }
}