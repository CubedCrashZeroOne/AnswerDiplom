using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeachSubs = new HashSet<TeachSub>();
        }

        public short IdTeach { get; set; }
        public short IdDep { get; set; }
        public string Surname { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public short? IdUser { get; set; }
        public string Login { get; set; }
        public string Parol { get; set; }

        public virtual Department IdDepNavigation { get; set; }
        public virtual ICollection<TeachSub> TeachSubs { get; set; }
    }
}
