using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class Clothing : Product, IDiscountable
    {
        public double Size { get; set; }
        public string Material { get; set; }
        public double DiscountPercent { get; set; }
        public Clothing(string name, double price, double size, string material, double discountpercent) : base(name, price)
        {
            Size = size;
            Material = material;
            DiscountPercent = discountpercent;

            ApplyDiscount(DiscountPercent);
        }

        public void ApplyDiscount(double percent)
        {
            if (percent < 0 || percent > 100)
            {
                Console.WriteLine("Invalid discount percentage!");
                return;
            }

            Price -= (Price * percent) / 100;
        }

        public override void GetProductDetails()
        {
            base.GetProductDetails();
            Console.WriteLine($"size: {Size}, material: {Material}, takhfif : {DiscountPercent}");
        }
    }
}
