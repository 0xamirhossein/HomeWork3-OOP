using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task3
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name , double price ) 
        {
            Name = name;
            Price = price;
        }
        public virtual void GetProductDetails()
        {
            Console.WriteLine($"name is {Name} price is {Price}, ");
        
        }
    }
}
