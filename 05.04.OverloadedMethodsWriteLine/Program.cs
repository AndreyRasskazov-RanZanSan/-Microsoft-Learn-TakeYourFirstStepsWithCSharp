using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._04.OverloadedMethodsWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}