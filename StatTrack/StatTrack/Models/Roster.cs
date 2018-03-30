using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Roster
    {
        public int RosterID { get; set; }
        public virtual Team Team { get; set; }
        public int TeamID { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Player> Lineup { get; set; }
    }
}