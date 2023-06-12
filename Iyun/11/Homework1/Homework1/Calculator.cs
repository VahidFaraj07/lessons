using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Calculator : Calculate
    {
        public override void Divide(double x, double y)
        {
            if (y != 0)
            {
                base.Subtract(x, y);
            }
            else
            {
                Console.WriteLine("Sifira bolme xetasi!");
            }
        }
    }
}
