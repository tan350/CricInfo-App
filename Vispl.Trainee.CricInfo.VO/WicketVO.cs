using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vispl.Trainee.CricInfo.VO
{
    public class WicketUpdateVO
    {
        public int MatchId { get; set; }
        public int BatsmanId { get; set; }
        public int BowlerId { get; set; }
        public int WicketTypeId { get; set; }
        public int? FielderId { get; set; }
    }


    public class WicketVO
    {
        public string BatsmanName { get; set; }
        public int TeamRuns { get; set; }
        public int TeamWickets { get; set; }
        public string TeamOvers { get; set; }
    }


}
