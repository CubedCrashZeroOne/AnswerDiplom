using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Test
    {
        public Test()
        {
            MarkTests = new HashSet<MarkTest>();
            ResultTests = new HashSet<ResultTest>();
            TestGroups = new HashSet<TestGroup>();
            ThemaTests = new HashSet<ThemaTest>();
        }

        public short IdTest { get; set; }
        public string NameTest { get; set; }
        public short? IdSub { get; set; }
        public short LengthMin { get; set; }
        public byte? Repeat { get; set; }

        public virtual Subject IdSubNavigation { get; set; }
        public virtual ICollection<MarkTest> MarkTests { get; set; }
        public virtual ICollection<ResultTest> ResultTests { get; set; }
        public virtual ICollection<TestGroup> TestGroups { get; set; }
        public virtual ICollection<ThemaTest> ThemaTests { get; set; }
    }
}
