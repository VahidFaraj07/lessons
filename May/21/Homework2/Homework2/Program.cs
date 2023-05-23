using System;
/*
Homework 2:
    Bir dənə kiçik console app yazın. Bu app sizdən sinif adı , sinif rəhbərinin adı axırda isə 10 tələbə adı soruşacaq.
    Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə saxlayın student1, student2, student3... və s.
    Sonra sinif adı, müəllim adı və tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
    Method cəmi 3 parametr qəbul edə bilər. 3-dən artıq parametr istifadə etmək haqqınız yoxdur. Axırda sinif haqqında məlumat yazısı
    və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın. Tələbə adlarını da collection və ya list
    şəklində göndərmək haqqınız yoxdur.İp ucu verim dərsdə keçmişdik.
*/
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string className, teacherName, student1, student2, student3, student4, student5, student6, student7, student8, student9, student10;

            Console.Write("Sinif adini daxil edin: ");
            className = Console.ReadLine();

            Console.Write("Sinif rehberinin adini daxil edin: ");
            teacherName = Console.ReadLine();

            Console.WriteLine("Telebelerin adini daxil edin ");
            student1 = Console.ReadLine();
            student2 = Console.ReadLine();
            student3 = Console.ReadLine();
            student4 = Console.ReadLine();
            student5 = Console.ReadLine();
            student6 = Console.ReadLine();
            student7 = Console.ReadLine();
            student8 = Console.ReadLine();
            student9 = Console.ReadLine();
            student10 = Console.ReadLine();

            
            classInfo(className, teacherName, student1, student2, student3, student4, student5, student6, student7, student8, student9, student10);


        }

        static void classInfo(string classN, string teacherN, params string[] students)
        {
            Console.Clear();
            Console.WriteLine($"Sinif: {classN}");
            Console.WriteLine($"Sinif rehberi: {teacherN}");
            Console.WriteLine();
            Console.WriteLine("Telebeler:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

        }
    }
}
