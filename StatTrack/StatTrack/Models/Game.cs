using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Game
    {
        public int GameID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Date Played")]
        public DateTime DatePlayed { get; set; }
        public bool IsPPD { get; set; }
        [DisplayName("Postponed")]
        public virtual Team Home { get; set; }
        public int HomeID { get; set; }
        public virtual Team Visitor { get; set; }
        public int VistorID { get; set; }
        [DisplayName("Home Result")]
        public string HomeResult { get; set; }
        [DisplayName("Visitor Result")]
        public string VistorResult { get; set; }
        [DisplayName("Home Score")]
        public int HomeScore { get; set; }
        [DisplayName("Visitor Score")]
        public int VisitorScore { get; set; }
        [DisplayName("Home Batting Stats")]
        public virtual ICollection<BattingStats> HomeBattingStats { get; set; }
        [DisplayName("Visitor Batting Stats")]
        public virtual ICollection<BattingStats> VistorBattingStats { get; set; }
        [DisplayName("Home Pitching Stats")]
        public virtual ICollection<PitchingStats> HomePitchingStats { get; set; }
        [DisplayName("Visitor Pitching Stats")]
        public virtual ICollection<PitchingStats> VisitorPitchingStats { get; set; }
    }
}