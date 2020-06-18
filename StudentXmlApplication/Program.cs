using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentXmlApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Student.xml";
            StudentParser studentParser = new StudentParser();
            studentParser.ReadXmlDetails(filePath);
            var obj=studentParser.GetStudentObject();
        }
    }
}
