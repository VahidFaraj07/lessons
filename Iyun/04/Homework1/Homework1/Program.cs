using System;
using System.Collections.Generic;
/*
Inner Type Homework:
Homework 1:
   Customer içində inner type olaraq yazacağınız array'lardakı dataları göstərən bir neçə methodunuz olacaq. 
   Həmin method'lar Customer'in öz məlumatlarını, Order'lərini, Contact'larını, Address'lərini və s. göstərəcək. 
   Main method'unda yaradacağınız customer instance'ının vasitəsilə həm ayrı-ayrılıqda Contact, Address və s., həm də bütün məlumatları da görmək olsun.
   Bütün məlumatlar dedikdə yəni, customer.ShowAllInfo() method'u bütün məlumatları çıxardacaq və ya customer.ShowAddresses() isə sadəcə ünvan məlumatlarını göstərəcək. 
   Ünvan məlumatlarında nəzərə alın ki, inner type olan'ların da property'ləri ekrana yazdırılsın. 
   Əgər EditDate null olarsa, o zaman "Data is not edited" olmazsa da editlənmə tarixi 12.12.2022 formatla göstərilsin.

   Məsələn Contact üzərindən bir nümunə verim.
   customer.ShowContacts() method'u ekrana bu şəkildə çıxmalıdır:
   Id: 1
   Email: orkhankhf@gmail.com
   PhoneNumber: +994555810872
   CreateDate: 12.12.2014
   EditDate: Data is not edited

   (əgər 2-ci Contact varsa aşağıdakı da çıxsın)
   Id: 2
   Email: test@gmail.com
   PhoneNumber: +994551231212
   CreateDate: 12.12.2015
   EditDate: 12.12.2018
*/

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                DocumentNo = 555555,
                BirthDate = DateTime.Now,
                CreateDate = DateTime.Now,
                EditDate = null
            };

            Country country = new Country()
            {
                Id = 1,
                Name = "Azerbaijan",
                CreateDate = DateTime.Now,
            };

            City city = new City()
            {
                Id = 1,
                Name = "Baku",
                Country = country,
                CreateDate = DateTime.Now
            };

            Order laptopOrder = new Order()
            {
                Id = 1,
                OrderDetails = "Asus Tuf fx705GM, 3800 usd",
                CreateDate = DateTime.Now
            };

            customer.Addresses[0] = new Address()
            {
                Id = 1,
                No = 15,
                Building = "MyBuilding",
                Street = "HomeStreet",
                Distinct = "Narimanov",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Addresses[1] = new Address()
            {
                Id = 2,
                No = 40,
                Building = "Residence",
                Street = "WorkStreet",
                Distinct = "Yasamal",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Contacts[0] = new Contact()
            {
                Id = 1,
                Email = "orkhan@mail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Orders[0] = new Order()
            {
                Id = 2,
                OrderDetails = "Samsung Galaxy S9+, 600 usd",
                ShippingAddress = customer.Addresses[1],
                CreateDate = DateTime.Now
            };

            customer.Orders[1] = laptopOrder;

            customer.ShowAllInfo();
            //customer.ShowOrders();
            //customer.ShowAddresses();
            //customer.ShowContacts();


        }
    }
}
