using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04.Step1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Secont decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

            Console.ReadKey();
        }
    }
}