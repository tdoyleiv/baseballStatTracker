using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string TeamName { get { return City + " " + Name; } }
        public virtual ICollection<Roster> Roster { get; set; }
        [DisplayName("Team History")]
        public virtual ICollection<Season> Seasons { get; set; }

    }
}