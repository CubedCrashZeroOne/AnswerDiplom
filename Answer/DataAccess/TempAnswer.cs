using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class TempAnswer
    {
        public short? IdStud { get; set; }
        public short? IdTest { get; set; }
        public DateTime? DateTest { get; set; }
        public int? IdQues { get; set; }
        public string IdAns { get; set; }
        public string TextA { get; set; }
    }
}
