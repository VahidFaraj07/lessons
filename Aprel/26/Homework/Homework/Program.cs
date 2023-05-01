using System;

/*
 Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm). Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. 
        İkincidə 50 daxil etdi onu da b dəyişənində saxlayın. Elə edin ki, bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. 
        Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.

 Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın.
        Nəticə: 5 + 5 + 10 = 20. Bunu çıxma, vurma və bölmə üçün də edin.

 Homework 3: İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın. Bu taskı da çıxma, vurma və bölmə üçün də edin. 
        Çıxmada və toplama əməliyyatlarında 10-cu dəyər daxil edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. 
        Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.

 Homework 4: İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun tipdə dəyişənlərə çevirəcəksiz. bool, string, short, long, int, char, datetime.
 */

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Homework1
            int a = 20;
            int b = 50;

            b += a;         // b=70
            a = b - a;      // a=50  
            b = b - a;      // b=30

            Console.WriteLine($"a = {a}, b = {b}");
            #endregion

            #region Homework2
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            int value3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Netice: {value1} + {value2} + {value3} = {value1 + value2 + value3}");
            Console.WriteLine($"Netice: {value1} - {value2} - {value3} = {value1 - value2 - value3}");
            Console.WriteLine($"Netice: {value1} * {value2} * {value3} = {value1 * value2 * value3}");
            Console.WriteLine($"Netice: {value1} / {value2} / {value3} = {(double)value1 / (double)value2 / (double)value3}");
            #endregion

            #region Homework3
            int toplama, cixma, vurma;
            double bolme;

            #region UserInputs
            int tempVar1 = Convert.ToInt32(Console.ReadLine());
            int tempVar2 = Convert.ToInt32(Console.ReadLine());
            int tempVar3 = Convert.ToInt32(Console.ReadLine());
            int tempVar4 = Convert.ToInt32(Console.ReadLine());
            int tempVar5 = Convert.ToInt32(Console.ReadLine());
            int tempVar6 = Convert.ToInt32(Console.ReadLine());
            int tempVar7 = Convert.ToInt32(Console.ReadLine());
            int tempVar8 = Convert.ToInt32(Console.ReadLine());
            int tempVar9 = Convert.ToInt32(Console.ReadLine());
            int tempVar10 = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Toplama
            toplama = tempVar1;
            toplama += tempVar2;
            toplama += tempVar3;
            toplama += tempVar4;
            toplama += tempVar5;
            toplama += tempVar6;
            toplama += tempVar7;
            toplama += tempVar8;
            toplama += tempVar9;
            toplama += tempVar10;
            toplama += 1;
            #endregion

            #region Cixma
            cixma = tempVar1;
            cixma -= tempVar2;
            cixma -= tempVar3;
            cixma -= tempVar4;
            cixma -= tempVar5;
            cixma -= tempVar6;
            cixma -= tempVar7;
            cixma -= tempVar8;
            cixma -= tempVar9;
            cixma -= tempVar10;
            cixma -= 1;
            #endregion

            #region Vurma
            vurma = tempVar1;
            vurma *= tempVar2;
            vurma *= tempVar3;
            vurma *= tempVar4;
            vurma *= tempVar5;
            vurma *= tempVar6;
            vurma *= tempVar7;
            vurma *= tempVar8;
            vurma *= tempVar9;
            vurma *= tempVar10;
            vurma *= 20;
            #endregion

            #region Bolme
            bolme = tempVar1;
            bolme /= tempVar2;
            bolme /= tempVar3;
            bolme /= tempVar4;
            bolme /= tempVar5;
            bolme /= tempVar6;
            bolme /= tempVar7;
            bolme /= tempVar8;
            bolme /= tempVar9;
            bolme /= tempVar10;
            bolme /= 20;
            #endregion

            Console.WriteLine($"{toplama}, {cixma}, {vurma}, {bolme}");
            #endregion

            #region Homework4
            bool aBool = bool.Parse(Console.ReadLine());
            string aString = Console.ReadLine();
            short aShort = short.Parse(Console.ReadLine());
            long aLong = long.Parse(Console.ReadLine());
            int aInt = int.Parse(Console.ReadLine());
            char aChar = char.Parse(Console.ReadLine());
            DateTime aDateTime = DateTime.Parse(Console.ReadLine());
            #endregion

        }
    }
}
