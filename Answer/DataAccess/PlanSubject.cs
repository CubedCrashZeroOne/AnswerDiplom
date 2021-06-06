using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class PlanSubject
    {
        public short IdPlan { get; set; }
        public short IdSub { get; set; }
        public short? Hours { get; set; }

        public virtual LeanPlan IdPlanNavigation { get; set; }
        public virtual Subject IdSubNavigation { get; set; }
    }
}
