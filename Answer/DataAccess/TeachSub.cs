using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class TeachSub
    {
        public short IdTeach { get; set; }
        public short IdSub { get; set; }
        public short? Status { get; set; }

        public virtual Subject IdSubNavigation { get; set; }
        public virtual Teacher IdTeachNavigation { get; set; }
    }
}
