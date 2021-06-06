using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Speciality
    {
        public Speciality()
        {
            Groups = new HashSet<Group>();
            LeanPlans = new HashSet<LeanPlan>();
        }

        public short IdSpec { get; set; }
        public string NameSpec { get; set; }
        public string CodeSpec { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<LeanPlan> LeanPlans { get; set; }
    }
}
