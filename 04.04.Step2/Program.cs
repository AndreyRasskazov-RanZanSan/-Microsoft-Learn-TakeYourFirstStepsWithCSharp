using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04.Step2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine("Second: " + value++);
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            Console.ReadKey();
        }
    }
}