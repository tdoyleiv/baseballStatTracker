using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class MLB
    {
        public int MLBID { get; set; }
        public virtual ICollection<League> Leagues { get; set; }
    }
}