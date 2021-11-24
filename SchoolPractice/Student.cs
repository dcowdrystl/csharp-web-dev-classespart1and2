using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
        

        public Student(string name, int id, int credits, double gpa) { 
           
            //We don't need to include the this in all of these
            this.Name = name;
            this.StudentId = id;
            this.NumberOfCredits = credits;
            this.Gpa = gpa;
            
        
        }
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
    }
}
