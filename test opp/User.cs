using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace test_opp
{
    internal class User
    {
        // แก้จาก Subject เป็น subject (s ตัวเล็ก)
        public subject currentSubject;

        // Z. เปิดวิชาใหม่
        public void OpenNewClass()
        {
            Console.Write("Enter Subject Name: "); string name = Console.ReadLine();
            Console.Write("Enter Subject Code: "); string code = Console.ReadLine();

            // ต้องมั่นใจว่า class subject มี constructor รับ (string, string)
            currentSubject = new subject(name, code);
            Console.WriteLine($"\n>>> Success: Opened Class {name} ({code})");
        }

        // เพิ่มนักศึกษา
        public void AddStudent()
        {
            if (currentSubject == null)
            {
                Console.WriteLine("!!! Error: Please open a class first (Press Z)");
                return;
            }
            Console.WriteLine($"\n--- Adding Student to {currentSubject.SubjectName} ---");
            Console.Write("First Name: "); string fn = Console.ReadLine();
            Console.Write("Last Name: "); string ln = Console.ReadLine();
            Console.Write("Student ID: "); string id = Console.ReadLine();
            Console.Write("Score: ");

            if (double.TryParse(Console.ReadLine(), out double sc))
            {
                // ตรวจสอบว่าในคลาส subject มี List ชื่อ StudentsInClass หรือไม่
                currentSubject.StudentsInClass.Add(new Student(fn, ln, id, sc));
                Console.WriteLine("Student added!");
            }
        }

        public void ShowMaxMin()
        {
            if (currentSubject == null || currentSubject.StudentsInClass.Count == 0)
            {
                Console.WriteLine("No student data."); return;
            }
            var max = currentSubject.StudentsInClass.OrderByDescending(s => s.Score).First();
            var min = currentSubject.StudentsInClass.OrderBy(s => s.Score).First();
            Console.WriteLine($"\n[Max Score]: {max.FirstName} {max.LastName} ({max.Score})");
            Console.WriteLine($"[Min Score]: {min.FirstName} {min.LastName} ({min.Score})");
        }

        public void ShowAll()
        {
            if (currentSubject == null) return;
            Console.WriteLine($"\n--- All Students in {currentSubject.SubjectName} ---");
            foreach (var s in currentSubject.StudentsInClass)
            {
                // ตรวจสอบว่าใน student มี Property ชื่อ StudentId และฟังก์ชัน GetGrade() หรือไม่
                Console.WriteLine($"ID: {s.Id} | {s.FirstName} {s.LastName} | Score: {s.Score} | Grade: {s.GetGrade()}");
            }
        }

        public void ShowAverage()
        {
            if (currentSubject == null || currentSubject.StudentsInClass.Count == 0) return;
            double avg = currentSubject.StudentsInClass.Average(s => s.Score);
            Console.WriteLine($"\nClass Average Score: {avg:F2}");
        }
    }
}