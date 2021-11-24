using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student Dan = new Student("Dan", 1, 69, 4.20);
            Console.WriteLine(Dan.GetGradeLevel());

            Dan.AddGrade(40, 1.2);
            Console.WriteLine($"Dan's new gpa after adding a course is {Dan.Gpa}");

            Console.WriteLine(Dan);

            Student violet = new Student("Violet", 2, 28, 3.5);
            bool areTheSame = Dan.Equals(violet);
            Console.WriteLine(areTheSame);
        }
    }
}
