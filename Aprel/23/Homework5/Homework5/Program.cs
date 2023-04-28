using System;
using System.Text;
/*
Homework 5:
             Global və Local dəyişən fərqlərini skoplarla izah edə biləcəyiniz bir kod nümunəsi hazırlayın.
 
*/

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {

            int testVar1 = 1;
            int testVar4 = 7;
            {
                {
                    Console.WriteLine($"{testVar1}");
                    testVar1 = 777;
                    Console.WriteLine($"{testVar1}");
                    int testVar2 = 42;
                    testVar4 = testVar2;

                }

                {
                    testVar1 = 111;
                    int testVar3 = testVar4;

                    // testVar2 = 22; seklinde yaza bilmirik
                    // testVar1 global, testVar2 lokal deyisendir
                }
            }

        }

    }
}
