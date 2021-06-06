using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class TestGroup
    {
        public short IdTest { get; set; }
        public short IdGr { get; set; }
        public DateTime? TestBegin { get; set; }
        public DateTime? TestEnd { get; set; }
        public bool? Allowed { get; set; }
        public bool? Admission { get; set; }

        public virtual Group IdGrNavigation { get; set; }
        public virtual Test IdTestNavigation { get; set; }
    }
}
