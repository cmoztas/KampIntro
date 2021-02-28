using System;

namespace Attributes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Öztaş", Age = 28 };

            CustomerDal customerDal = new CustomerDal();

            customerDal.Add(customer);
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    internal class Customer
    {
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }

        [RequiredProperty]
        public string LastName { get; set; }

        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} added!");
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} added!");
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}