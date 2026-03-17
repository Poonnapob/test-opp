using System;
using System.Collections.Generic; /

namespace test_opp
{
    public class subject
    {
     
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }

       
        public List<Student> StudentsInClass { get; set; } = new List<Student>();

      
        public subject(string name, string code)
        {
            this.SubjectName = name;
            this.SubjectCode = code;
        }
    }
}