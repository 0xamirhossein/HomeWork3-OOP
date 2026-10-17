namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Electronics("Laptop", 50000000, 24),
                new Electronics("Mobile Phone", 25000000, 12),
                new Clothing("T-Shirt", 500000, 37, "Cotton", 0),
                new Clothing("Jeans", 1200000, 54, "Jean", 30)
            };

            foreach (Product product in products)
            {
               product.GetProductDetails();
            }



        }
    }
}
