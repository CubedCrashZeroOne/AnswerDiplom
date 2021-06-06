using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class SubBaseQuest
    {
        public short IdSub { get; set; }
        public string NameSub { get; set; }
        public string ShortNameSub { get; set; }
        public int? CountTh { get; set; }
        public int? CountQ { get; set; }
    }
}
