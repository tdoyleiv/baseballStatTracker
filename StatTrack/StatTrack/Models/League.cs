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
        public ICollection<Division> Divisions { get; set; }
    }
}