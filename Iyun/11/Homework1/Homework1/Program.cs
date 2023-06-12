using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = 0;

            Calculator c1 = new Calculator();
            c1.Add(a, b);
            c1.Subtract(a, b);
            c1.Multiply(a, b);
            c1.Divide(a, b);

        }
    }
}
