using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentXmlApplication
{
    class Subjects
    {
        private int _totalMarks;
        private bool _isPassed;
        public Subjects( int totalMarks, bool isPassed)
        {
            _totalMarks = totalMarks;
            _isPassed = isPassed;       
        }
    }
    class StudentInfo
    {
        private Subjects _referSubjects;
        private string _studentName;
        public StudentInfo(string studentName)
        {
            _studentName = studentName;
        }
        public void Add(Subjects subjects)
        {
            _referSubjects = subjects;
        }
    }
    class StudentData
    {
        private List<StudentInfo> _students;
        public StudentData()
        {
            _students = new List<StudentInfo>();
        }
        public void Add(StudentInfo studentInfo)
        {
            _students.Add(studentInfo);
        }
    }
}
