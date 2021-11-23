using System;
using System.Collections.Generic;
namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student Dan = new Student("Dan", 500, 1, 4.0);
            Student John = new Student("John", 400, 1, 4.0);
            Student Pri = new Student("Pri", 300, 1, 4.0);
            /*Dan.Name = "Dan";
              Dan.StudentId = 500;
              Dan.NumberOfCredits = 1;
              Dan.Gpa = 4.0;*/
            List<Student> roster = new List<Student>();
            roster.Add(Dan);
            roster.Add(John);
            roster.Add(Pri);

            Course codeCamp = new Course("STLCC CodeCamp", "Gerrard", roster);
            Teacher gerrard = new Teacher("Gerrard", "Darris", "Web Dev", 8);

            Console.WriteLine($"{Dan.Name} ({Dan.StudentId})");
            Console.WriteLine($"Credits: {Dan.NumberOfCredits}, GPA: {Dan.Gpa}");

           

            Console.WriteLine($"The name of the course is {codeCamp.Title}");
            Console.WriteLine($"The name of the teacher is {gerrard.FirstName}");

            Console.ReadLine();
        }
    }
}
