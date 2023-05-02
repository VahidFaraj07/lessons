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
        repeat:
            Console.Write("Asagidaki emeliyyatlardan birini secin.\n1. Toplama\n2. Cixma\n3. Vurma\n4. Bolme\nSeciminiz: ");
            int action = Convert.ToInt32(Console.ReadLine());

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine($"Cavab: {a + b}\n");
                    goto repeat;

                case 2:
                    Console.WriteLine($"Cavab: {a - b}\n");
                    goto repeat;

                case 3:
                    Console.WriteLine($"Cavab: {a * b}\n");
                    goto repeat;

                case 4:
                    Console.WriteLine($"Cavab: {(double)a / (double)b}\n");
                    goto repeat;

            }
        }
    }
}
