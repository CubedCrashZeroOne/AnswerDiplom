using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class MarkTest
    {
        public int IdMark { get; set; }
        public DateTime DateTest { get; set; }
        public short IdStud { get; set; }
        public short IdTest { get; set; }
        public byte? KolTrue { get; set; }
        public byte? KolFalse { get; set; }
        public byte? KolHalf { get; set; }
        public byte Bal { get; set; }
        public byte PerCent { get; set; }

        public virtual Student IdStudNavigation { get; set; }
        public virtual Test IdTestNavigation { get; set; }
    }
}
