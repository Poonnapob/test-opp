using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test_opp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User userManager = new User();
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n*********************************");
                Console.WriteLine(" Z. Open New Class");
                Console.WriteLine(" S. Add Student to Current Class");
                Console.WriteLine(" A. Show Max/Min Scores");
                Console.WriteLine(" B. List All Students");
                Console.WriteLine(" C. Show Class Average Score");
                Console.WriteLine(" X. Exit Program");
                Console.WriteLine("*********************************");
                Console.Write("Select Choice: ");

                string choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "Z": userManager.OpenNewClass(); break;
                    case "S": userManager.AddStudent(); break;
                    case "A": userManager.ShowMaxMin(); break;
                    case "B": userManager.ShowAll(); break;
                    case "C": userManager.ShowAverage(); break;
                    case "X": keepRunning = false; break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }
    }
}