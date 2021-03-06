﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Sport
    {
        public int SportID { get; set; }
        public virtual ICollection<League> Leagues { get; set; }
        public virtual ICollection<BattingStats> MLBBattingStats { get; set; }
        public virtual ICollection<PitchingStats> MLBPitchingStats { get; set; }
    }
}