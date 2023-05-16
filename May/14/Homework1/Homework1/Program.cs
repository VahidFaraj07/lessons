using System;
/*
 Homework 1:
 Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.

 Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
 Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
 tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq. 
 */

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ad: ");
            string name = Console.ReadLine();
            Console.Write("Soyad: ");
            string surname = Console.ReadLine();
            Console.WriteLine();

            byte price1, price2, price3;
            Console.Write("1. Qiymet: ");
            byte.TryParse(Console.ReadLine(), out price1 );
            Console.Write("2. Qiymet: ");
            byte.TryParse(Console.ReadLine(), out price2 );
            Console.Write("3. Qiymet: ");
            byte.TryParse(Console.ReadLine(), out price3 );

            Console.Clear();

            showInfo(name, surname, price1, price2, price3);
            showInfo(name, surname, price1, price2);                            // default deyer ucun

            Student newStudent = new Student();

            double ortalama = newStudent.CalcAverage(price1, price2, price3);

            newStudent.CalcAverage(price1, price2, price3, name, surname);         // overload ucun

            newStudent.RateAverage(ortalama);

        }

        public static void showInfo(string sName, string sSurname, byte sPrice1, byte sPrice2, byte sPrice3 = 51)
        {
            Console.WriteLine($"Telebe: {sName} {sSurname}          - Fennler uzre aldigi qiymetleri: {sPrice1}, {sPrice2}, {sPrice3}.");
        }

    }
}
