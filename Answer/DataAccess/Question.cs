using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            ResultTests = new HashSet<ResultTest>();
        }

        public int IdQues { get; set; }
        public short? IdTheme { get; set; }
        public string TextQ { get; set; }
        public string TextQRtf { get; set; }
        public byte[] Picture { get; set; }
        public bool? Pict { get; set; }
        public byte? KolTrue { get; set; }
        public bool? IsRtf { get; set; }

        public virtual ThemeSub IdThemeNavigation { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<ResultTest> ResultTests { get; set; }
    }
}
