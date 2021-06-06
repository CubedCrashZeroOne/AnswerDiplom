using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Subject
    {
        public Subject()
        {
            PlanSubjects = new HashSet<PlanSubject>();
            TeachSubs = new HashSet<TeachSub>();
            Tests = new HashSet<Test>();
            ThemeSubs = new HashSet<ThemeSub>();
        }

        public short IdSub { get; set; }
        public string NameSub { get; set; }
        public string ShortNameSub { get; set; }

        public virtual ICollection<PlanSubject> PlanSubjects { get; set; }
        public virtual ICollection<TeachSub> TeachSubs { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<ThemeSub> ThemeSubs { get; set; }
    }
}
