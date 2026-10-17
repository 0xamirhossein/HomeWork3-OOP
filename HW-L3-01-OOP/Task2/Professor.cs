using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Professor : Person
    {
        public string ProfessorID { get; set; }
        public string Subject { get; set; }

        public  Professor(string name, string age, string professorid, string subject):base(name,age)
        {
            ProfessorID = professorid;
            Subject = subject;

        }
        public override void GetDetails()
        {
            Console.WriteLine($" Proffessor name is {Name} and age is {Age} and ProfessorID is {ProfessorID} and Subject is {Subject}");

        }
    }
}
