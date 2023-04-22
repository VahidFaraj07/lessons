using System;

/*
Homework 3:
 int, bool, char, string və long tipində dəyişənlər yaradıb onlara dəyər verirsiniz. Sonra elə bir dəyişən yaratmalısınız ki, bütün bu dəyişənləri
 ona dəyər olaraq mənimsədə biləsiniz. 
*/
namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            bool b = true;
            char c = 'Z';
            string d = "Programming";
            long e = 1000;

            var a1 = a;
            Console.WriteLine(a1);

            var b1 = b;
            Console.WriteLine(b1);

            var c1 = c;
            Console.WriteLine(c1);

            var d1 = d;
            Console.WriteLine(d1);

            var e1 = e;
            Console.WriteLine(e1);

            Console.ReadLine();

        }
    }
}
