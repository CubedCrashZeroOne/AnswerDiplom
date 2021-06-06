using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class ThemeSub
    {
        public ThemeSub()
        {
            Questions = new HashSet<Question>();
            ThemaTests = new HashSet<ThemaTest>();
        }

        public short IdTheme { get; set; }
        public string NameTheme { get; set; }
        public short IdSub { get; set; }
        public byte IdKind { get; set; }
        public byte Bal { get; set; }

        public virtual TestKind IdKindNavigation { get; set; }
        public virtual Subject IdSubNavigation { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ThemaTest> ThemaTests { get; set; }
    }
}
