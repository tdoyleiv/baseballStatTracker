using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Game
    {
        public int GameID { get; set; }
        [DisplayName("Date Played")]
        public DateTime DatePlayed { get; set; }
        public Team Home { get; set; }
        public int HomeID { get; set; }
        public Team Visitor { get; set; }
        public int VistorID { get; set; }
        [DisplayName("Home Result")]
        public string HomeResult { get; set; }
        [DisplayName("Visitor Result")]
        public string VistorResult { get; set; }
        [DisplayName("Home Score")]
        public int HomeScore { get; set; }
        [DisplayName("Visitor Score")]
        public int VisitorScore { get; set; }
    }
}