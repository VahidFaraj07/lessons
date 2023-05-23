using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Customer
    {
        internal void CheckCustomerFromDb() {
            Console.WriteLine("Internal access modifier ile verilmis metodlara (public-den ferqli olaraq)yalniz hemin proje daxilinden muraciet etmek mumkundur.");
        }
    }
}
