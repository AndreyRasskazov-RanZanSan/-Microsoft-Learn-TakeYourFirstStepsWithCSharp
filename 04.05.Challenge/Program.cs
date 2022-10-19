using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._05.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;
            decimal celsius = ((decimal)fahrenheit - 32) * ((decimal)5 / 9);

            Console.WriteLine($"The temperature is {celsius} Celsius.");
            Console.ReadKey();
        }
    }
}