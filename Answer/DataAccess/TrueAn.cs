using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class TrueAn
    {
        public int IdQues { get; set; }
        public string Ans { get; set; }
        public byte PerCent { get; set; }

        public virtual Question IdQuesNavigation { get; set; }
    }
}
