using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class TempQuest
    {
        public short? IdStud { get; set; }
        public short? IdTest { get; set; }
        public DateTime? DateTest { get; set; }
        public int? IdQues { get; set; }
        public short? IdTheme { get; set; }
        public string TextQ { get; set; }
        public bool? Pict { get; set; }
        public byte[] Picture { get; set; }
        public byte? KolTrue { get; set; }
    }
}
