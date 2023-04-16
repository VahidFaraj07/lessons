using System;

/*
Homework 1:
    İstifadəçidən adını, soyadını, yaşadığı şəhəri soruşun və bunları dəyişənlərdə saxlayın.
*/




namespace Homeworks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter name of your living city: ");
            string city = Console.ReadLine();

        }
    }
}


/*
 Homework 2:
 İstifadəçidən 10 ədəd şəhər adı daxil etməsini istəyin. İstifadəçi 10-cu şəhər adını daxil etdikdən sonra sıra ilə şəhər adlarını alt-alta ekrana yazdırın.
 Məsələn:
 Bakı
 Gəncə
 Sumqayıt

 Homework 3:
 Eyni qaydada istifadəçidən 10 ədəd şəhər adı soruşun. 10-cu şəhərin adını daxil edəndən sonra bu dəfə alt-alta yox vergüllə ayırıb yazın.
 Məsələn: Baki, Gence, Sumqayit

 Qeyd: Bu 3 tapşırığı etmək üçün 3 ayrı yeni Console Application yaradın. Eyni solution içində yazmayın.
 */
