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
        [DisplayName("Team Name")]
        [StringLength(160)]
        public string Name { get; set; }
        public virtual ICollection<Player> Roster { get; set; }
        [DisplayName("Team History")]
        public virtual ICollection<Season> Seasons { get; set; }

    }
}