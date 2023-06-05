using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Homework
{
    public class Customer
    {
        private string _username, _password;

        private static ArrayList db;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                if (IsUsernameExists(value))
                {
                    this._username = null;
                }
                else
                {
                    this._username = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (PassIsOkay(value))
                {
                    this._password = value;

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
            if (!IsNullOrEmpty(obj.Id.ToString(), obj.Name, obj.Surname, obj.Email, obj._username, obj._password))
            {
                if (IsEmailExists(obj.Email))
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

        private static bool IsUsernameExists(string tempUsername)
        {
            foreach (Customer item in db)
            {
                if (item._username.ToString() == tempUsername)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool PassIsOkay(string tempPass)
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

        private static bool IsEmailExists(string tempEmail)
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


        private static bool IsNullOrEmpty(params string[] par)
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
