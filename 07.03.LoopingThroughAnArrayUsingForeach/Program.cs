using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03.LoopingThroughAnArrayUsingForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bob", "Conrad", "Grant" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}