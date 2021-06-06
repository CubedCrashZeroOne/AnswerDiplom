using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Department
    {
        public Department()
        {
            Teachers = new HashSet<Teacher>();
        }

        public short IdDep { get; set; }
        public string NameDep { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
