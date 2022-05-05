using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public List<Student> StudentRoster { get; set; }

        public Course(string name, string teacher, List<Student> studentRoster)
        {
            Name = name;
            Teacher = teacher;
            StudentRoster = studentRoster;
        }
    }
}
