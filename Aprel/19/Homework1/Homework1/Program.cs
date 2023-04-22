using System;

/*
    Homework 1:
    Ev tapşırığı olaraq ilk növbədə ən az 2-3 saat internetdə "C# data types" (C# veri tipleri) mövzusunu geniş bir şəkildə araşdırırsınız.
    Araşdıra-araşdıra da bir Console App açıb araşdırdığınız data tiplərindən nümunələr yazırsınız. Hər data type üçün ən az 5 fərqli nümunə yazın.
 */

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte aByte = 0, bByte = 255, cByte = 100, dByte = 223, eByte = 1;
            Console.WriteLine($"aByte = {aByte}\nbByte = {bByte}\ncByte = {cByte}\ndByte = {dByte}\neByte = {eByte}\n");

            sbyte aSbyte = -128, bSbyte = 127, cSbyte = 0, dSbyte = -23, eSbyte = 7;
            Console.WriteLine($"aSbyte = {aSbyte}\nbSbyte = {bSbyte}\ncSbyte = {cSbyte}\ndSbyte = {dSbyte}\neSbyte = {eSbyte}\n");

            short aShort = -32768, bShort = -32767, cShort = 1, dShort = -100, eShort = 123;
            Console.WriteLine($"aShort = {aShort}\nbShort = {bShort}\ncShort = {cShort}\ndShort = {dShort}\neShort = {eShort}\n");

            ushort aUshort = 0, bUshort = 65535, cUshort = 23223, dUshort = 777, eUshort = 1;
            Console.WriteLine($"aUshort = {aUshort}\nbUshort = {bUshort}\ncUshort = {cUshort}\ndUshort = {dUshort}\neUshort = {eUshort}\n");

            int aInt = -2147483648, bInt = 2147483647, cInt = 0, dInt = -1, eInt = 1;
            Console.WriteLine($"aInt = {aInt}\nbInt = {bInt}\ncInt = {cInt}\ndInt = {dInt}\neInt = {eInt}\n");

            uint aUint = 0, bUint = 4294967295, cUint = 111, dUint = 777, eUint = 1;
            Console.WriteLine($"aUint = {aUint}\nbUint = {bUint}\ncUint = {cUint}\ndUint = {dUint}\neUint = {eUint}\n");

            long aLong = -9223372036854775808, bLong = 9223372036854775807, cLong = -1, dLong = 1111222233334444555, eLong = 1;
            Console.WriteLine($"aLong = {aLong}\nbLong = {bLong}\ncLong = {cLong}\ndLong = {dLong}\neLong = {eLong}\n");

            ulong aUlong = 0, bUlong = 18446744073709551615, cUlong = 1, dUlong = 11112222333344445555, eUlong = 7;
            Console.WriteLine($"aUlong = {aUlong}\nbUlong = {bUlong}\ncUlong = {cUlong}\ndUlong = {dUlong}\neUlong = {eUlong}\n");

            float aFloat = -1.5F, bFloat = 3.4F, cFloat = -1.2F, dFloat = 0.7F, eFloat = 23.7F;
            Console.WriteLine($"aFloat = {aFloat}\nbFloat = {bFloat}\ncFloat = {cFloat}\ndFloat = {dFloat}\neFloat = {eFloat}\n");


            double aDouble = -3.0, bDouble = 6.8, cDouble = -2.4, dDouble = 1.4, eDouble = 45.4;
            Console.WriteLine($"aDouble = {aDouble}\nbDouble = {bDouble}\ncDouble = {cDouble}\ndDouble = {dDouble}\neDouble = {eDouble}\n");

            decimal aDecimal = -6.0m, bDecimal = 13.6m, cDecimal = -4.8m, dDecimal = 2.8m, eDecimal = 90.8m;
            Console.WriteLine($"aDecimal = {aDecimal}\nbDecimal = {bDecimal}\ncDecimal = {cDecimal}\ndDecimal = {dDecimal}\neDecimal = {eDecimal}\n");

            bool aBool = true, bBool = false, cBool = true, dBool = true, eBool = true;
            Console.WriteLine($"aBool = {aBool}\nbBool = {bBool}\ncBool = {cBool}\ndBool = {dBool}\neBool = {eBool}\n");

            char aChar = 'A';
            char bChar = 'b';
            char cChar = (char)55;      // ASCII
            char dChar = '\u0023';     // Unicode
            char eChar = '\x0047';     // Hexadecimal
            Console.WriteLine($"aChar = {aChar}\nbChar = {bChar}\ncChar = {cChar}\ndChar = {dChar}\neChar = {eChar}\n");

            string aString = "Milky Way", bString = "Andromeda (M31)", cString = "Triangulum (M33)", dString = "Large Magellanic Cloud", eString = "Small Magellanic Cloud";
            Console.WriteLine($"aString = {aString}\nbString = {bString}\ncString = {cString}\ndString = {dString}\neString = {eString}\n");

            Console.ReadLine();      // this line was written for results review.
        }
    }
}
