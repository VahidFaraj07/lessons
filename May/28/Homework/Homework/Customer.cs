using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Homework
{
    public class Customer
    {
        private string username, password;
        private static ArrayList db;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Username

        {
            get
            {
                return this.username;
            }
            set
            {
                if (isUsernameExists(value))
                {
                    this.username = null;
                }
                else
                {
                    this.username = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (passIsOkay(value))
                {
                    this.password = value;

                }
                else
                {
                    Console.WriteLine("Sifre en az 8 simvoldan ibaret, icinde en az 1 boyuk herf ve 1 reqem olmalidir.");
                }
            }
        }


        static Customer()
        {
            db = new ArrayList();
        }

        public static void AddCustomer(Customer obj)
        {
            if (!isNullOrEmpty(obj.Id.ToString(), obj.Name, obj.Surname, obj.Email, obj.username, obj.password))
            {
                if (isEmailExists(obj.Email))
                {
                    Console.WriteLine("Elave etmek istediyiniz email artiq sistemde movcuddur!");
                }
                else
                {
                    db.Add(obj);
                    Console.WriteLine("Yeni musteri sisteme elave olundu!");
                }
            }
        }

        private static bool isUsernameExists(string tempUsername)
        {
            foreach (Customer item in db)
            {
                if (item.username.ToString() == tempUsername)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool passIsOkay(string tempPass)
        {
            bool hasLower = false;
            bool hasUpper = false;
            bool hasDigit = false;
            if (tempPass.Length < 8)
            {
                return false;
            }
            else
            {
                foreach (char letter in tempPass)
                {
                    if (Char.IsLower(letter))
                    {
                        hasLower = true;
                    }
                    else if (Char.IsUpper(letter))
                    {
                        hasUpper = true;
                    }
                    else if (Char.IsDigit(letter))
                    {
                        hasDigit = true;
                    }
                    if (hasLower && hasUpper && hasDigit)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool isEmailExists(string tempEmail)
        {
            foreach (Customer item in db)
            {
                if (item.Email == tempEmail)
                {
                    return true;
                }
            }
            return false;
        }


        private static bool isNullOrEmpty(params string[] par)
        {
            foreach (var item in par)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
