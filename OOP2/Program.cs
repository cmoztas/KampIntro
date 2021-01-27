using System;

namespace OOP2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Individual customer1 = new Individual
            {
                Id = 1,
                CitizenNumber = "12345678901",
                CustomerNumber = "12345",
                Name = "Çağkan Mert",
                Surname = "Öztaş"
            };

            Corporate customer2 = new Corporate
            {
                CustomerNumber = "54321",
                Id = 2,
                CompanyName = "Kodlama.io",
                TaxNumber = "1234567890"
            };

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}