using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OPP
{
    public abstract class Question
    {
      

        public string? Header { get; set; }
        public string? Body { get; set; }
        public double Mark { get; set; }

       internal Answer[] AnswerList { get; set; }
        internal Answer CorrectAnswer { get; set; }

        public  Question(string header , string body , double mark )
        {
            
            Header = header;    
            Body = body;
            Mark = mark;
           
        }
        public abstract void DisplayQuestion();
    }
}
