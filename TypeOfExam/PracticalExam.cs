using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OPP.TypeOfExam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int NumberOfQuestions) : base(time, NumberOfQuestions) { }

        public override void ShowExam()
        {
            foreach (dynamic question in Questions)
            {
                question.DisplayQuestion();
                Console.WriteLine(   $"Correct Answer: { question.CorrectAnswer.AnswerText}");
               
            }
        }

    }
}
