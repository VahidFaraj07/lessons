using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        #region Inner Type required field
        public Contact[] Contacts;
        public Address[] Addresses;
        public Order[] Orders;
        #endregion

        #region Constructor
        public Customer()
        {
            Contacts = new Contact[100];
            Addresses = new Address[100];
            Orders = new Order[100];
        }
        #endregion

        #region ShowContacts
        public void ShowContacts()
        {
            for (int i = 0; i < Contacts.Length; i++)
            {
                Console.WriteLine($"Id: {Contacts[i].Id}");
                Console.WriteLine($"Email: {Contacts[i].Email}");
                Console.WriteLine($"PhoneNumber: {Contacts[i].PhoneNumber}");
                Console.WriteLine($"CreateDate: {Contacts[i].CreateDate.ToString("dd.MM.yyyy")}");
                if (Contacts[i].EditDate == null)
                {
                    Console.WriteLine($"EditDate: Data is not edited");
                }
                else
                {
                    Console.WriteLine($"EditDate: {Contacts[i].EditDate?.ToString("dd.MM.yyyy")}");
                }
            }
        }
        #endregion

        #region ShowAddresses
        public void ShowAddresses()
        {
            for (int i = 0; i < Addresses.Length; i++)
            {
                Console.WriteLine($"Id: {Addresses[i].Id}");
                Console.WriteLine($"No: {Addresses[i].No}");
                Console.WriteLine($"Building: {Addresses[i].Building}");
                Console.WriteLine($"Street: {Addresses[i].Street}");
                Console.WriteLine($"Distinct: {Addresses[i].Distinct}");
                Console.WriteLine($"CreateDate: {Addresses[i].CreateDate.ToString("dd.MM.yyyy")}");
                if (Addresses[i].EditDate == null)
                {
                    Console.WriteLine($"EditDate: Data is not edited");
                }
                else
                {
                    Console.WriteLine($"EditDate: {Addresses[i].EditDate?.ToString("dd.MM.yyyy")}");
                }

                Console.WriteLine($"CityName: {Addresses[i].City.Name}");
                Console.WriteLine($"CountryName: {Addresses[i].City.Country.Name}");
                Console.WriteLine();
            }

        }
        #endregion

        #region ShowOrders
        public void ShowOrders()
        {

            for (int i = 0; i < Orders.Length; i++)
            {
                Console.WriteLine($"Id: {Orders[i].Id}");
                Console.WriteLine($"OrderDetails: {Orders[i].OrderDetails}");
                Console.WriteLine($"ShippingAddress: {Orders[i].ShippingAddress.Distinct}");
                Console.WriteLine($"CreateDate: {Orders[i].CreateDate}");
                if (Orders[i].EditDate == null)
                {
                    Console.WriteLine($"EditDate: Data is not edited");
                }
                else
                {
                    Console.WriteLine($"EditDate: {Orders[i].EditDate?.ToString("dd.MM.yyyy")}");
                }
                Console.WriteLine();

            }
            

            





        }
        #endregion

        #region ShowAllInfo
        public void ShowAllInfo()
        {
            Console.WriteLine($"CustomerId: {Id}");
            Console.WriteLine($"CustomerName: {Name}");
            Console.WriteLine($"CustomerSurname: {Surname}");
            Console.WriteLine($"CustomerDocumentNo: {DocumentNo}");

            Console.WriteLine($"CustomerBirthDate: {BirthDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"CustomerCreateDate: {CreateDate.ToString("dd.MM.yyyy")}");
            if (EditDate == null)
            {
                Console.WriteLine($"CustomerEditDate: Data is not edited");
            }
            else
            {
                Console.WriteLine($"EditDate: {EditDate?.ToString("dd.MM.yyyy")}");
            }
            Console.WriteLine();
            ShowContacts();
            ShowAddresses();
            ShowOrders();


        }
        #endregion

    }
}
