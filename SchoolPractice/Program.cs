using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student nick = new Student("Nick", 1, 1, 4.0);
            Student jenelle = new Student("Jenelle", 1, 1, 4.0);
            Student francesca = new Student("Francesca", 1, 1, 4.0);
            //Console.WriteLine($"The Student class works! \nName: {nick.Name} \nStudent Id: {nick.StudentId} \nCredits: {nick.NumberOfCredits} \nGPA: {nick.Gpa}");
            List<Student> students = new List<Student>();
            students.Add(nick);
            students.Add(jenelle);
            students.Add(francesca);

            Course codeCamp = new Course("Code Camp 101", "Professor Odegard", students);
            Console.WriteLine($"Name: {codeCamp.Name}");
            Console.WriteLine($"Name: {codeCamp.Teacher}");
            Console.WriteLine("Student Roster");

            foreach (Student student in students)
            {
                Console.WriteLine($"..........\nName: {student.Name} \nStudent Id: {student.StudentId} \nCredits: {student.NumberOfCredits} \nGPA: {student.Gpa}");
            }
        }
    }
}
