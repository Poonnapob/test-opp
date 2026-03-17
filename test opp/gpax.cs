using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_opp
{
    internal class gpax
    {
       
        public double ConvertGradeToPoint(string grade)
        {
            switch (grade)
            {
                case "A": return 4.0;
                case "B+": return 3.5;
                case "B": return 3.0;
                case "C+": return 2.5;
                case "C": return 2.0;
                case "D+": return 1.5;
                case "D": return 1.0;
                default: return 0.0;
            }
        }

        public void CalculateTotalGPAX(List<Student> students)
        {
            if (students.Count == 0) { Console.WriteLine("No data for calculation."); return; }

            double totalPoints = 0;
            foreach (var s in students)
            {
                string grade = s.GetGrade();
                totalPoints += ConvertGradeToPoint(grade);
            }

            double average = totalPoints / students.Count;
            Console.WriteLine($"\nTotal GPAX of class: {average:F2}");
        }
    }
}