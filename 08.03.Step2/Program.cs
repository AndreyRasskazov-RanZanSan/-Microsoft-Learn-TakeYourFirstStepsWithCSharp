using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03.Step2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int widgetsPurchased = 7;
            // Testing a change to the message.
            // int widgetsSold = 7;
            // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
            Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

            Console.ReadKey();
        }
    }
}