using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Address CustomerAddress { get; set; }

        public static void ShowCustomerItems(Customer customer)
        {
            Console.WriteLine($"Id: {customer.Id}");
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Surname: {customer.Surname}");
            Console.WriteLine($"Age: {customer.Age}");
            Console.WriteLine($"AddressId: {customer.CustomerAddress.Id}");
            Console.WriteLine($"AddressNo: {customer.CustomerAddress.No}");
            Console.WriteLine($"Building: {customer.CustomerAddress.Building}");
            Console.WriteLine($"Street: {customer.CustomerAddress.Street}");
            Console.WriteLine($"City: {customer.CustomerAddress.City}");
            Console.WriteLine($"Country: {customer.CustomerAddress.Country}");
            Console.WriteLine();
        }
    }
}
