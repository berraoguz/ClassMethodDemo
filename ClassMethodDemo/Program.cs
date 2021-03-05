using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Berra";
            customer1.CustomerSurname = "Oğuz";
            customer1.CustomerAge = 20;
            customer1.CustomerId = 1;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Öznur";
            customer2.CustomerSurname = "Oğuz Solmaz";
            customer2.CustomerAge = 35;
            customer2.CustomerId = 2;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Hüseyin";
            customer3.CustomerSurname = "Oğuz";
            customer3.CustomerAge = 61;
            customer3.CustomerId = 3;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Customer[] customersArray = new Customer[] { customer1, customer2, customer3 };

            List<Customer> customersList = new List<Customer>() { customer1, customer2, customer3 };
            customerManager.GetAllCustomers(customersArray);
            customerManager.GetAllCustomers(customersList);

            customerManager.Remove(customer2);


        }
    }
}
