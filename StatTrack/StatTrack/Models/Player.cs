using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        public string FullName { get { return LastName + ", " + FirstName; } }
        public int Age { get; set; }
        public int Number { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Career Debut")]
        public DateTime CareerDebut { get; set; }
        public virtual Position Position { get; set; }
        public int PositionID { get; set; }
        [DisplayName("Career")]
        public virtual ICollection<Season> Seasons { get; set; }
    }
}