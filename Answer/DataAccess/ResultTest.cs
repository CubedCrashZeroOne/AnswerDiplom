using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class ResultTest
    {
        public int IdRez { get; set; }
        public short IdStud { get; set; }
        public short IdTest { get; set; }
        public DateTime DateTest { get; set; }
        public int IdQues { get; set; }
        public string AnsQOrder { get; set; }
        public string Answer { get; set; }
        public decimal? BalResult { get; set; }

        public virtual Question IdQuesNavigation { get; set; }
        public virtual Student IdStudNavigation { get; set; }
        public virtual Test IdTestNavigation { get; set; }
    }
}
