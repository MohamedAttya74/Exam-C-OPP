using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OPP.TypeOfQuestion
{
    internal class MCQ_Question : Question
    {
        public MCQ_Question(string header, string body, double mark) : base(header, body, mark) { }


        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}    ");
            Console.WriteLine($"{Body}    ");

            for (int i = 0; i < AnswerList.Length; i++)
            {


                Console.WriteLine($"{i + 1} ,  {AnswerList[i].AnswerText}");

            }
        }




    }
}
