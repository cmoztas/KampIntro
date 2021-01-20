using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager pm = new ProductManager();

            Product product1 = new Product()
            {
                Id = 1,
                Name = "Elma",
                Price = 10,
                Description = "Yeşil Elma"
            };

            pm.Add(product1);
            Console.WriteLine(product1.Name);
        }
    }
}
