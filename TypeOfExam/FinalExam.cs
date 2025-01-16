using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OPP.TypeOfExam
{
    internal class FinalExam :Exam
    {
        public FinalExam(int time  , int NumberOfQuestions) :base(time , NumberOfQuestions){ }


        public override void ShowExam()
        {
            foreach (dynamic question in Questions)
            {
                question.DisplayQuestion();
                Console.WriteLine("Answers:");
                foreach (dynamic answer in question.AnswerList)
                {
                    Console.WriteLine($"===> {answer.AnswerText}");
                }
                Console.WriteLine();
            }
        }

    }
}
