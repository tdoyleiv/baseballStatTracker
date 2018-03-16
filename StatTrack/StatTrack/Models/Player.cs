using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
        public Position Position { get; set; }
        public int PositionID { get; set; }
        [DisplayName("Player History")]
        public virtual ICollection<PlayerSeason> PlayerHistory { get; set; }
    }
}