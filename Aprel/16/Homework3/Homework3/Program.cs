using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 city names: ");

            #region ReadCityNames
            string firstCity = Console.ReadLine();
            string secondCity = Console.ReadLine();
            string thirdCity = Console.ReadLine();
            string fourthCity = Console.ReadLine();
            string fifthCity = Console.ReadLine();
            string sixthCity = Console.ReadLine();
            string seventhCity = Console.ReadLine();
            string eighthCity = Console.ReadLine();
            string ninthCity = Console.ReadLine();
            string tenthCity = Console.ReadLine();
            #endregion

            Console.Clear();

            # region WriteCityNames
            Console.Write(firstCity + ", ");
            Console.Write(secondCity + ", ");
            Console.Write(thirdCity + ", ");
            Console.Write(fourthCity + ", ");
            Console.Write(fifthCity + ", ");
            Console.Write(sixthCity + ", ");
            Console.Write(seventhCity + ", ");
            Console.Write(eighthCity + ", ");
            Console.Write(ninthCity + ", ");
            Console.WriteLine(tenthCity);
            #endregion

            Console.ReadLine();     // this line was written for results review.
        }
    }
}
