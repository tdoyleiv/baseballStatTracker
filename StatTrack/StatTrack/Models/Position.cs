using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Position
    {
        public int PositionID { get; set; }
        [DisplayName("Position")]
        [StringLength(2)]
        public string Name { get; set; }
    }
}