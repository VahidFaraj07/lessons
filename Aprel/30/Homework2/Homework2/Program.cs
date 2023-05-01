using System;
/*
Homework 2:
Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma və bölmə. 
İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. 
İstifadəçi istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
 
*/

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int action = 0, a = 0, b = 0;
            switch (action)
            {
                case 0:
                    Console.Write("Asagidaki emeliyyatlardan birini secin.\n1. Toplama\n2. Cixma\n3. Vurma\n4. Bolme\nSeciminiz: ");
                    action = Convert.ToInt32(Console.ReadLine());

                    Console.Write("a = ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    if (action == 1)
                    {
                        goto case 1;
                    }
                    else if (action == 2)
                    {
                        goto case 2;
                    }
                    else if (action == 3)
                    {
                        goto case 3;
                    }
                    else if (action == 4)
                    {
                        goto case 4;
                    }
                    else {
                        break;
                    }

                case 1:
                    Console.WriteLine($"Cavab: {a + b}\n");
                    goto case 0;
                case 2:
                    Console.WriteLine($"Cavab: {a - b}\n");
                    goto case 0;
                case 3:
                    Console.WriteLine($"Cavab: {a * b}\n");
                    goto case 0;
                case 4:
                    Console.WriteLine($"Cavab: {(double)a / (double)b}\n");
                    goto case 0;

            }
        }
    }
}
