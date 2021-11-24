using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string Title { get; set; }
        public string Instructor { get; set; }
        public List<Student> StudentRoster { get; set; }

        public Course(string title, string instructor, List<Student> roster)
        {
            Title = title;
            Instructor = instructor;
            StudentRoster = roster;
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Title == course.Title &&
                   Instructor == course.Instructor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Instructor);
        }
    }
}
