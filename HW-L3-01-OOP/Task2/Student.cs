using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Task2
{
    internal class Student : Person
    {
        public string StudentID { get; set;}
        public string Major { get; set; }

        public Student(string name, string age, string studentID, string major) : base(name, age)
        {
            StudentID = studentID;
            Major = major;
        }
        public override void GetDetails()
        {
            
            Console.WriteLine($"STUDENT name is {Name} and age is {Age} andStudentID is {StudentID} and Major is {Major}");
        }

    }
}
