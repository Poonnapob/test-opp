using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_opp
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public double Score { get; set; }

        public Student(string f, string l, string id, double s)
        {
            FirstName = f; LastName = l; Id = id; Score = s;
        }

        public string GetGrade()
        {
            if (Score >= 80) return "A";
            if (Score >= 75) return "B+";
            if (Score >= 70) return "B";
            if (Score >= 65) return "C+";
            if (Score >= 60) return "C";
            if (Score >= 55) return "D+";
            if (Score >= 50) return "D";
            return "F";
        }
    }
}