using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._06.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");

            Console.ReadKey();
        }
    }
}