using System;
/*
 Homework 1:
             5 dənə dəyişəni Implicit Conversion,
             5 dənə dəyişəni Explicit Conversion,
             5 dənə dəyişəni Helper Class Conversion vasitəsilə convert edin. 
             Dəyişən tiplərini və dəyərlərini özünüz seçin.
 
*/

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit
            short aScore = 1;
            int aImpScore = aScore;

            int bScore = 7;
            long bImpScore = bScore;

            float cScore = 23.0F;
            double cImpScore = cScore;

            short dScore = 42;
            long dImpScore = dScore;

            byte eScore = 100;
            int eImpScore = eScore;

            //explicit
            int aBalance = 1;
            short aExpBalance = (short)aBalance;

            long bBalance = 7;
            int bExpBalance = (int)bBalance;

            double cBalance = 23.0F;
            float cExpBalance = (float)cBalance;

            long dBalance = 42;
            short dExpBalance = (short)dBalance;

            int eBalance = 100;
            byte eExpBalance = (byte)eBalance;

            //Helper Class Conversion
            bool aResult = true;
            string aResult1 = Convert.ToString(aResult);
            Console.WriteLine(aResult1);

            int bResult = 23;
            string bResult1 = Convert.ToString(bResult);
            Console.WriteLine(bResult1);

            byte cResult = 0;
            bool cResult1 = Convert.ToBoolean(cResult);
            Console.WriteLine(cResult1);

            string dResult = "723";
            int dResult1 = Convert.ToInt32(dResult);
            Console.WriteLine(dResult1);

            bool eResult = true;
            byte eResult1 = Convert.ToByte(eResult);
            Console.WriteLine(eResult1);


            #region ForResultsReview
            Console.ReadLine();
            #endregion




        }
    }
}
