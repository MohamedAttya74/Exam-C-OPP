using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OPP
{
    public abstract class Exam
    {

        public int Time { get; set; }

        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; } //  **********************************



        public Exam(int time, int numberOfQuestion)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestion;
            Questions = new List<Question>();
        }
        public abstract void ShowExam();
    }
    }
