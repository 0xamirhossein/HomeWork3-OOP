using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public long NationalID { get; set; }
        
        public Person(string name, int age, long nationalID)
        {
            Name = name;
            Age = age;
            NationalID = nationalID;
        }


        public string GetDetails() // use virtual if we want to override method in derived class 
        {
            return $"name is {Name} age is {Age}, code meli : {NationalID} ";
        }
    }
}
