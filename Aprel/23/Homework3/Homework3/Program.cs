using System;
using System.Text;
/*
Homework 3:
İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız.
Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert edəcəksiniz.
Daha sonra int dəyişənini byte tipinə cast edəcəksiniz (explicit conversion).
Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. 
Maaşını və ya yaşını byte tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.
*/

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Yaş: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maaş: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Boy: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Çəki: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dostların sayı: ");
            int fCount = Convert.ToInt32(Console.ReadLine());

            checked
            {
                byte ageCast = (byte)age;
                byte salaryCast = (byte)salary; 
            }


            unchecked
            {
                byte heightCast = (byte)height;
                byte weightCast = (byte)weight;
                byte fCountCast = (byte)fCount;
            }
            

        }
    }
}
