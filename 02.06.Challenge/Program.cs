using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._06.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int messageCount = 3;
            decimal temperature = 34.4m;

            Console.WriteLine("Hello, " + firstName + "! You have " + messageCount + " messages in your inbox. The temperature is " + temperature + " celsius.");
            Console.ReadKey();
        }
    }
}