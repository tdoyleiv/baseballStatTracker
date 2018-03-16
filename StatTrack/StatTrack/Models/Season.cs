using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Season
    {
        public int SeasonID { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}