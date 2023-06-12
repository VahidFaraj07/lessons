using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public interface ICalculate
    {
        void Add(double x, double y);
        void Subtract(double x, double y);
        void Multiply(double x, double y);
        void Divide(double x, double y);
    }
}
