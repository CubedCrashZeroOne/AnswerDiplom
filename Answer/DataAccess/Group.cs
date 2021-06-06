using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
            TestGroups = new HashSet<TestGroup>();
        }

        public short IdSpec { get; set; }
        public short IdGr { get; set; }
        public string NameGr { get; set; }
        public byte Curs { get; set; }
        public byte? Kol { get; set; }

        public virtual Speciality IdSpecNavigation { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<TestGroup> TestGroups { get; set; }
    }
}
