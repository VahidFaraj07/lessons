using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public abstract class Calculate : ICalculate
    {
        public void Add(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtract(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiply(double x, double y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public virtual void Divide(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

    }
}
