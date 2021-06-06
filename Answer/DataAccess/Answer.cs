using System;
using System.Collections.Generic;

#nullable disable

namespace DiplomAnswerProject
{
    public partial class Answer
    {
        public int IdQues { get; set; }
        public string IdAns { get; set; }
        public string TextA { get; set; }
        public string TextARtf { get; set; }
        public byte[] PictAns { get; set; }

        public virtual Question IdQuesNavigation { get; set; }
    }
}
