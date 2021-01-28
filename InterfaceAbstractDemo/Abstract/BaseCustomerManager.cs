using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine($"Saved to db: {customer.FirstName}");
        }
    }
}