using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._06.Challenge.Ver._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int messageCount = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(firstName);
            Console.Write("! You have ");
            Console.Write(messageCount);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");

            Console.ReadKey();
        }
    }
}