using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class LeanPlan
    {
        public LeanPlan()
        {
            PlanSubjects = new HashSet<PlanSubject>();
        }

        public short IdPlan { get; set; }
        public short IdSpec { get; set; }
        public short LearnYear { get; set; }
        public byte? Curs { get; set; }
        public byte? Semester { get; set; }
        public string NamePlan { get; set; }

        public virtual Speciality IdSpecNavigation { get; set; }
        public virtual ICollection<PlanSubject> PlanSubjects { get; set; }
    }
}
