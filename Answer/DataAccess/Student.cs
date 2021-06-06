using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Student
    {
        public Student()
        {
            MarkTests = new HashSet<MarkTest>();
            ResultTests = new HashSet<ResultTest>();
        }

        public short IdStud { get; set; }
        public string Number { get; set; }
        public string Surname { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public short IdGr { get; set; }
        public short? YearEnter { get; set; }
        public byte[] Foto { get; set; }

        public virtual Group IdGrNavigation { get; set; }
        public virtual ICollection<MarkTest> MarkTests { get; set; }
        public virtual ICollection<ResultTest> ResultTests { get; set; }
    }
}
