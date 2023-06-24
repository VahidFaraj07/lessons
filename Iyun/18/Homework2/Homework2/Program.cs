using System;
/*
Homework 2:
Generic class yaradaraq (Repository) Add, Update, Get, Delete method'larını yazın. 
Həmin repository'nin instance'ını:
    Student, Customer, Teacher və Book class'ları ilə yaradıb hər bir method'u istifadə edə bilməlisiz. 
GenericRepository class'ı üçün İnterface'də istifadə edin.
*/
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook1 = new Book {
                Id = 0,
                Name = "C#",
                Author = "Vahid",
                CountOfPages = 223
            };

            Book newBook2 = new Book
            {
                Id = 1,
                Name = "Python",
                Author = "Vahid",
                CountOfPages = 223
            };

            Book newBook3 = new Book
            {
                Id = 3,
                Name = "Python",
                Author = "Vaka",
                CountOfPages = 777
            };

            GenericRepository<Book> connectionA = new GenericRepository<Book>();
            connectionA.Add(newBook1, newBook1.Id);
            connectionA.Add(newBook2, newBook2.Id);
            connectionA.Update(newBook3, newBook3.Id);

            //connectionA.Get(0);
            //connectionA.Delete(1);
            //connectionA.Get(1);
        }
    }
}
