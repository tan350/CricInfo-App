﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vispl.Trainee.CricInfo.VO
{
    public class PlayerVO
    {
        public int JerseyNo { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string BirthPlace { get; set; }
        public int? Role { get; set; }
        public int? PlayerType { get; set; }
        /*public string IsCaptain { get; set; }*/
        public int? Nationality { get; set; }
        public int? Team { get; set; }
        public int MatchesPlayed { get; set; }
        public int RunsScored { get; set; }
        public int WicketsTaken { get; set; }
        public double BattingAverage { get; set; }
        public double BowlingAverage { get; set; }
        public int Centuries { get; set; }
        public int HalfCenturies { get; set; }
        public DateTime DebutDate { get; set; }
        public int ICCRanking { get; set; }
        public byte[] Picture { get; set; }

    }

    public class PlayerListVO
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }

    }

}
