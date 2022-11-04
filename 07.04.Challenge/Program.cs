using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._04.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ordersID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach(string order in ordersID)
            {
                if(order.StartsWith("B"))
                {
                    Console.WriteLine(order);
                }
            }

            Console.ReadKey();
        }
    }
}