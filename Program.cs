using Exam_C__OPP.TypeOfExam;
using Exam_C__OPP.TypeOfQuestion;

namespace Exam_C__OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Subject ID");
            int SubjectID =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject Name : ");
            string SubjectName = Console.ReadLine();
            Subject subject = new Subject(SubjectID, SubjectName);
            Console.WriteLine("  Enter Exam Type  FinalExam OR PracticalExam  ");
            string ExamType = Console.ReadLine();

            Console.WriteLine("Enter Exam Time in Minutes:");
            int examTime = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Number Of Questions :");
            int numberOfquestion = int.Parse(Console.ReadLine());

            //Exam exam;

            if ( ExamType == "FinalExam") {

                new FinalExam(examTime, numberOfquestion);
            }else if (ExamType == "PracticalExam")
            {
                new PracticalExam(examTime, numberOfquestion);
            }

           for (int i = 0; i< numberOfquestion; i++)
            {

                Console.WriteLine($"Enter Question {i + 1} With TypeQuestion ==> MCQ OR True/False  ");
                string questionType = Console.ReadLine();

                Console.WriteLine("Enter Question Header ");

                String header =  Console.ReadLine();


                Console.WriteLine("Enter Question Body  ");
                string body= Console.ReadLine();
                
                Console.WriteLine("Enter Question Mark   ");
                int  mark= int .Parse(Console.ReadLine());

              Question question ;

               if (questionType == "True/False")
                {
                    new TrueandFalseQuestion(header, body, mark);

                    Console.WriteLine( $"Mark This Question {mark} ");

                }
                else if (questionType == "MCQ")
                {
                    new MCQ_Question(header, body, mark);
                    Console.WriteLine($" Mark This Question {mark} ");

                }


            }



        }
    }
}
