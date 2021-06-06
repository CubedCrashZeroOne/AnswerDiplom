using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class ThemaTest
    {
        public short IdTest { get; set; }
        public short IdTheme { get; set; }
        public byte CountQ { get; set; }
        public byte? OrderThema { get; set; }

        public virtual Test IdTestNavigation { get; set; }
        public virtual ThemeSub IdThemeNavigation { get; set; }
    }
}
