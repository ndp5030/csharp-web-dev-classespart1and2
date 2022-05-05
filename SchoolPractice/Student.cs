using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; } = 0;
        public double Gpa { get; set; } = 0.0;

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return $"..........\nName: {Name} \nStudent Id: {StudentId} \nCredits: {NumberOfCredits} \nGPA: {Gpa} \nGrade Level: {GetGradeLevel(NumberOfCredits)}";
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            double totalCreditPoints = Gpa * NumberOfCredits;
            totalCreditPoints += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = totalCreditPoints / NumberOfCredits;
        }

        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            //Freshman (0-29 credits), Sophomore (30-59 credits), Junior (60-89 credits), or Senior (90+ credits)
            if (credits <= 29) 
            {
                return "Freshman";
            } else if (credits <= 59)
            {
                return "Sophomore";
            } else if (credits <= 89)
            {
                return "Junior";
            } else
            {
                return "Senior";
            }
        }





        //public Student(string name, int studentId) : this(name, studentId, 0, 0.0) { }

        //public Student(string name): this(name, nextStudentId)
        //{
        //    nextStudentId++;
        //}

    }
}
