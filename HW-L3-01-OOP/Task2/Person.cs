using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public Person(string name, string age)
        {
            Name = name;
            Age = age;
        }
        public virtual void  GetDetails()
        {
            
            Console.WriteLine($"Name is : {Name} and Age is {Age}");
        }
    }
}
