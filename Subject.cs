using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OPP
{
    internal class Subject
    {

        public int SubjectID { get; set; }
        public string? SubjectName { get; set; }

        public Exam? exam { get; set; }

        public Subject( int id , string subjectname)
        {
            SubjectID = id;
            SubjectName = subjectname;

        }

        public void CreateExam(Exam examm)
        {
            exam = examm;
        }
    }
}
