using System;
using System.Text;
/*
Homework 2:
Bir dənə anket proqramı yığacaqsınız. İstifadəçidən onun haqqında məlumatları toplayacaqsınız.
Bu məlumatlar ad, soyad, cins, doğum tarixi, yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq.
Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.

İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:

Ad: Mark
Soyad: Henry
Cins: K və ya Q
Doğum tarixi: 1990-10-10
Yaşadığı ölkə: Azərbaycan
Yaşadığı şəhər: Bakı
Boy: 1.75
Çəki: 26.50
Maaş: 2500.00
*/

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Ad: ");
            string name = Console.ReadLine();

            Console.Write("Soyad: ");
            string surname = Console.ReadLine();

            Console.Write("Cinsiniz: ");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Doğum tarixi(yyyy.mm.dd): ");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Yaşadığınız ölkə: ");
            string country = Console.ReadLine();

            Console.Write("Yaşadığınız şəhər: ");
            string city = Console.ReadLine();

            Console.Write("Boy: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Çəki: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Maaş: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Ad: {name}\nSoyad: {surname}\nCins: {gender}\nDoğum tarixi: {dateOfBirth}\nYaşadığı ölkə: {country}\nYaşadığı şəhər: {city}\nBoy: {height}\nÇəki: {weight}\nMaaş: {salary}");

        }
    }
}
