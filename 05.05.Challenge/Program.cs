using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._05.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);

            Console.ReadKey();
        }
    }
}