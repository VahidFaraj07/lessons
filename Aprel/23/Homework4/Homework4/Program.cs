using System;
using System.Text;
/*
Homework 4:
             Aşağıdakı dəyərləri düzgün tiplərdə dəyişənlər yaradıb saxlayın:
             1: "Hava gozeldir."
             2: '%'
             3: 9999999999999999
             4: true
             5: false
             6: '0'
             7: 0
             8: 150
             9: -111111111115615
             10: 15.2M
             11: 15.2
             12: 15.2F
             13: new DateTime(2020, 12, 12)
 */

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = "Hava gozeldir.";
            char percent = '%';
            long a = 9999999999999999;
            bool b1 = true;
            bool b2 = true;
            char c1 = '0';
            byte c2 = 0;
            byte d = 150;
            long e = -111111111115615;
            decimal f1 = 15.2M;
            double f2 = 15.2;
            float f3 = 15.2F;
            DateTime k = new DateTime(2020, 12, 12);

            Console.Clear();

            Console.WriteLine($"1: {weather}");
            Console.WriteLine($"2: {percent}");
            Console.WriteLine($"3: {a}");
            Console.WriteLine($"4: {b1}");
            Console.WriteLine($"5: {b2}");
            Console.WriteLine($"6: {c1}");
            Console.WriteLine($"7: {c2}");
            Console.WriteLine($"8: {d}");
            Console.WriteLine($"9: {e}");
            Console.WriteLine($"10: {f1}");
            Console.WriteLine($"11: {f2}");
            Console.WriteLine($"12: {f3}");
            Console.WriteLine($"13: {k}");

            Console.ReadLine();


        }
    }
}
