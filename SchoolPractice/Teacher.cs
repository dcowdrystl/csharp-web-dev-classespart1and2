using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public Teacher(string firstname, string lastname, string subject, int yearsteaching)
        {
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;
            YearsTeaching = yearsteaching;
        }
    }
}
