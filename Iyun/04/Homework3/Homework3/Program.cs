using System;
/*
Homework 2:
    Aşağıda yazdığım class'ların property'lərini base class'a çıxardıb inherit almaq lazımdır. Nəyi necə edəcəyinizə qarışmıram özünüz qərar verin...

Employee: 
    Id, 
    ReferanceNumber, 
    DocumentNumber, 
    Name, 
    Surname, 
    Gender, 
    DateOfStartWorking, 
    DateOfEndWorking, 
    RestDays, 
    RegUser, 
    RegDate, 
    EditUser, 
    EditDate, 
    Deleted

Teacher: 
    Id, 
    ReferanceNumber, 
    DocumentNumber, 
    Name, 
    Surname, 
    Gender, 
    DateOfStartWorking, 
    DateOfEndWorking, 
    RestDays, 
    Branch, 
    Level, 
    RegUser, 
    RegDate, 
    EditUser, 
    EditDate, 
    Deleted

Student: 
    Id,
    ReferanceNumber, 
    DocumentNumber, 
    Name, 
    Surname, 
    Gender, 
    Department,
    Level,
    RegUser, 
    RegDate, 
    EditUser, 
    EditDate, 
    Deleted

*/

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 1,
                ReferanceNumber = 1,
                DocumentNumber = 1,
                Name = "",
                Surname = "",
                Gender = "",
                DateOfStartWorking = DateTime.Now,
                DateOfEndWorking = DateTime.Now,
                RestDays = 1,
                RegUser = "",
                RegDate = DateTime.Now,
                EditUser = "",
                EditDate = DateTime.Now,
                Deleted = true,
            };

            Teacher teacher = new Teacher()
            {
                Id = 1,
                ReferanceNumber = 1,
                DocumentNumber = 1,
                Name = "",
                Surname = "",
                Gender = "",
                DateOfStartWorking = DateTime.Now,
                DateOfEndWorking = DateTime.Now,
                RestDays = 1,
                Branch = "",
                Level = 1,
                RegUser = "",
                RegDate = DateTime.Now,
                EditUser = "",
                EditDate = DateTime.Now,
                Deleted = true,
            };

            Student student = new Student()
            {
                Id = 1,
                ReferanceNumber = 1,
                DocumentNumber = 1,
                Name = "",
                Surname = "",
                Gender = "",
                Department = "",
                Level = 1,
                RegUser = "",
                RegDate = DateTime.Now,
                EditUser = "",
                EditDate = DateTime.Now,
                Deleted = true,
            };

        }
    }
}
