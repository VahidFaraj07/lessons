using System;
using System.Collections.Generic;

/*
Homework 1:
Customer class'ının Id, Name, Surname, Age property'ləri olsun. 
Birdə əlavə olaraq Address Class'ı yaradıb onu da inner type olaraq Customer'ə property kimi əlavə edin. 
Address'in bu property'ləri olacaq: Id, No, Building, Street, City, Country. 
City və Country'ni Address'in içində string olaraq verin əlavə Class'a çıxarmağa ehtiyyac yoxdur.
2-3 dənə Customer və onların Address'lərini əlavə edib sonra Customer tipində bir listə yığın. 
Sizdən istədiyim odur ki, Foreach ilə (customers.Foreach()) aşağıdakı kimi dataları yazdırasınız:
    ID: 1
    Name: Cavid
    Surname: Cavidov
    Age: 20
    Address Info:
    ID: 100
    No: 10
    Building: Some Building
    Street: Some Street
    City: Some City
    Country: Some Country

    ID: 2
    Name: Hasan
    Surname: Hasanov
    Age: 32
    Address Info:
    ID: 100
    No: 10
    Building: Some Building
    Street: Some Street
    City: Some City
    Country: Some Country
 */

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Name1",
                Surname = "Surname1",
                Age = 21,
                CustomerAddress = new Address
                {
                    Id = 1,
                    No = 1001,
                    Building = "Building N-1",
                    Street = "Street N-1",
                    City = "City N-1",
                    Country = "Country N-1",
                }
            };
            customers.Add(customer1);

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Name2",
                Surname = "Surname2",
                Age = 22,
                CustomerAddress = new Address
                {
                    Id = 2,
                    No = 1002,
                    Building = "Building N-2",
                    Street = "Street N-2",
                    City = "City N-2",
                    Country = "Country N-2",
                }
            };
            customers.Add(customer2);

            Customer customer3 = new Customer
            {
                Id = 3,
                Name = "Name3",
                Surname = "Surname3",
                Age = 23,
                CustomerAddress = new Address
                {
                    Id = 3,
                    No = 1003,
                    Building = "Building N-3",
                    Street = "Street N-3",
                    City = "City N-3",
                    Country = "Country N-3",
                }
            };
            customers.Add(customer3);

            customers.ForEach(Customer.ShowCustomerItems);

        }
    }
}
