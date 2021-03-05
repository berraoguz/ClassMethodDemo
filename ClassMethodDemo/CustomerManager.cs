using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " added.");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " removed.");
        }

        public void GetAllCustomers(Customer[] customersArray)
        {
            Console.WriteLine("--------Customer Array--------");
            foreach (var customer in customersArray)
            {
                Console.WriteLine("Customer Name: {0} - Age: {1}", customer.CustomerName, customer.CustomerAge);
            }
            Console.WriteLine("\n");
        }

        internal void GetAllCustomers(List<Customer> customersList)
        {
            Console.WriteLine("--------Customer List--------");
            foreach (var customer in customersList)
            {
                Console.WriteLine("Customer Name: {0} - Age: {1}", customer.CustomerName, customer.CustomerAge);
            }
        }
    }
}
