using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04.IncrementAndDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            value = value + 5;
            Console.WriteLine(value);
            value += 5;
            Console.WriteLine(value);

            Console.ReadKey();

            value = 0;
            value = value + 1;
            Console.WriteLine(value);
            value++;
            Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}