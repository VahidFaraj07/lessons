using System;
/*
OOP - Inheritance Homework:
Homework 1:
        Aşağıdakı class'ları yaradın. Nəzərə alın ki, inheritance'dan istifadə edərək property'ləri düzgün class içərisində yaratmalısız.
             Car:                   Phone:                      Teacher:
                Id,                     Id,                         Id,
                Brand,                  Brand,                      Name,
                Model,                  Model,                      Surname,
                Km,                     FastCharge,                 BirthDate,
                Engine,                 MadeInCountry,              Gender,
                Price,                  Price,                      CreateDate,
                CreateDate,             CreateDate,                 EditDate
                EditDate                EditDate           
                
*/


namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Id = 1,
                Brand = "",
                Model = "",
                Km = 0.0,
                Engine = "",
                Price = 0.0m,
                CreateDate = DateTime.Now,
                EditDate = DateTime.Now,
            };

            Phone phone = new Phone()
            {
                Id = 1,
                Brand = "",
                Model = "",
                FastCharge = true,
                MadeInCountry = "",
                Price = 0.0m,
                CreateDate = DateTime.Now,
                EditDate = DateTime.Now,
            };

            Teacher teacher = new Teacher()
            {
                Id = 1,
                Name = "",
                Surname = "",
                BirthDate = DateTime.Now,
                Gender = "",
                CreateDate = DateTime.Now,
                EditDate = DateTime.Now,
            };

        }
    }
}
