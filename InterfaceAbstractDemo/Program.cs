using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager();
            customerManager.Save(new Customer()
            {
                DateOfBirth = new DateTime(1993, 10, 27),
                FirstName = "Çağkan Mert",
                Id = 1,
                LastName = "Öztaş",
                NationalityId = "20182087064"
            });
        }
    }
}