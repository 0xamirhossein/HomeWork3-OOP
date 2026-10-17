using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class Electronics : Product
    {
        public int WarrantyPeriod { get; set; }
        public string Material { get; set; }
        public Electronics(string name, double price, int warrantyperiod) : base(name, price)
        {
            WarrantyPeriod = warrantyperiod;
        }


        public override void GetProductDetails()
        {
            base.GetProductDetails();
            Console.WriteLine($"warranty period time is : {WarrantyPeriod}");
        }
    }
}
