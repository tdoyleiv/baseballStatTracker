using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Division
    {
        public int DivisionID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<BattingStats> DivisionBattingStats { get; set; }
        public virtual ICollection<PitchingStats> DivisionPitchingStats { get; set; }
    }
}