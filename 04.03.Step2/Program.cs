using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.Step2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine("Decimal quotient: " + decimalQuotient);
            Console.ReadKey();

            // Here are two additional examples that work equally well:
            // decimal decimalQuotient = 7 / 5.0m;
            // decimal decimalQuotient = 7.0m / 5.0m;

            // However, the following lines of code won't work (or will give inaccurate results):
            // int decimalQuotient = 7 / 5.0m;
            // int decimalQuotient = 7.0m / 5;
            // int decimalQuotient = 7.0m / 5.0m;
            // decimal decimalQuotient = 7 / 5;
        }
    }
}