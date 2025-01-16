using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OPP
{
    internal class Answer  
    {
        public int AnswerID { get; set; }
        public string? AnswerText { get; set; }
        public Answer( int id , string text)
        {
             AnswerID = id;
            AnswerText = text;
        }
    }
}
