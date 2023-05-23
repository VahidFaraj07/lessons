using System;
/*
Homework 1:
    Local function'lar yaradaraq bir kalkulyator yaradın.
    Ümumi bir calculate methodu olmalıdır və o method'un içində də Toplama, Çıxma, Vurma və Bölmə local function'ları olacaq.
    Ümumi Calculate method'unun overload'ları olmalıdır və iki decimal, iki int, iki string, string-decimal, decimal-int və 
    int-string parametrləri ilə işləməlidir.
    Nümunə: İki int, iki decimal dedikdə onu nəzərdə tuturam ki, Calculate(15, 15), Calculate(15.2M, 20.5M) qaydada istifadə ediləcək.
    Ancaq string-decimal dedikdə yəni parametrin biri string digəri decimal olacaq ("15", 20.2M) yada int-string üçün (20, "15") belə.
    Bölmə zamanı divide zero exeption'dan qaçının.
    Birdə Calculator'un 2 variant faiz hesablama funksiyası da olacaq. Birinci variant A parametrinin B parametr faizi neçədir?
    Yəni 100-ün 5 faizi neçədir? hesablayacaq. İkinci variant isə A parametri B parametrinin neçə faizidir? Yəni 10 (a parametri),
    100-ün (b parametrinin) neçə faizidir?
 */

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            string p1, p2, operation;

            Console.Write("Ededleri daxil edin:\n1-ci eded: ");
            p1 = Console.ReadLine();

            Console.Write("2-ci eded: ");
            p2 = Console.ReadLine();

            Console.WriteLine("\nRiyazi emeliyyatlardan birini secin:\n1. Toplama\n2. Cixma\n3. Vurma\n4. Bolme\n5. Faiz hesablama");
            operation = Console.ReadLine();
            Console.Clear();

            Calculate(p1, p2, operation);

        }

        #region Calculate
        static void Calculate(decimal val1, decimal val2, string op)
        {
            decimal value1 = val1;
            decimal value2 = val2;

            switch (op)
            {
                case "1":
                    Addition(value1, value2);
                    break;
                case "2":
                    Substraction(value1, value2);
                    break;
                case "3":
                    Multiplication(value1, value2);
                    break;
                case "4":
                    Division(value1, value2);
                    break;
                case "5":
                    CalcOfPerc(value1, value2);
                    break;
            }

            void Addition(decimal v1, decimal v2)
            {
                Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
            }

            void Substraction(decimal v1, decimal v2)
            {
                Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
            }

            void Multiplication(decimal v1, decimal v2)
            {
                Console.WriteLine($"{v1} * {v2} = {v1 * v2}");
            }

            void Division(decimal v1, decimal v2)
            {

                if (v2 != 0)
                    Console.WriteLine($"{v1} * {v2} = {v1 * v2}");
                else
                {
                    Console.WriteLine("Divide zero exeption");
                }
            }

            void CalcOfPerc(decimal v1, decimal v2)
            {
                Console.WriteLine($"\"{v1}\" ededi \"{v2}\" ededinin {(int)(v1 * 100 / v2)}%-ni teskil edir.");
                Console.WriteLine($"\"{v2}\" ededi \"{v1}\" ededinin {(int)(v2 * 100 / v1)}%-ni teskil edir.");

            }

        }
        #endregion

        #region OverloadsOfCalculate
        //string-string
        static void Calculate(string p1, string p2, string operation) {
            decimal.TryParse(p1, out decimal value1);
            decimal.TryParse(p2, out decimal value2);

            Calculate(value1, value2, operation);
        }

        //int-int
        static void Calculate(int p1, int p2, string operation)
        {
            Calculate((decimal)p1, (decimal)p2, operation);
        }

        //string-decimal
        static void Calculate(string p1, decimal p2, string operation)
        {
            decimal.TryParse(p1, out decimal value1);
            Calculate(value1, p2, operation);
        }

        //decimal-int
        static void Calculate(decimal p1, int p2, string operation)
        {
            Calculate(p1, (decimal)p2, operation);
        }

        //int-string
        static void Calculate(int p1, string p2, string operation)
        {
            decimal.TryParse(p2, out decimal value2);
            Calculate((decimal)p1, value2, operation);
        }

        #endregion

    }
}


