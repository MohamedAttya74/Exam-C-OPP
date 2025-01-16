using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OPP.TypeOfQuestion
{
    internal class TrueandFalseQuestion : Question
    {

             public TrueandFalseQuestion(string header, string body, double mark) : base (header, body, mark) { }



        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}   True Or False  ");
            Console.WriteLine(Body);     
        }



    }
}
