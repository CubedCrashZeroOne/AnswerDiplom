using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class TestKind
    {
        public TestKind()
        {
            ThemeSubs = new HashSet<ThemeSub>();
        }

        public byte IdKind { get; set; }
        public string NameKind { get; set; }

        public virtual ICollection<ThemeSub> ThemeSubs { get; set; }
    }
}
