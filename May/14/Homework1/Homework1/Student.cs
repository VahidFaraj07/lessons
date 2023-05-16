using System;

namespace Homework1
{
    class Student
    {
        public double CalcAverage(byte a, byte b, byte c)
        {
            return (double)(a + b + c) / 3.0;
        }

        public void CalcAverage(byte a, byte b, byte c, string name, string surname)
        {
            Console.WriteLine($"Telebe: {name} {surname}          - Fennler uzre ortalama bali: {(double)(a + b + c) / 3.0}");
        }

        public void RateAverage(double ortalama)
        {
            Console.Write("Rating: ");
            if (ortalama < 51)
            {
                Console.WriteLine("F");
            }
            else if (ortalama < 60)
            {
                Console.WriteLine("E");
            }
            else if (ortalama < 70)
            {
                Console.WriteLine("D");
            }
            else if (ortalama < 80)
            {
                Console.WriteLine("C");
            }
            else if (ortalama < 90)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }
        }
    }
}
