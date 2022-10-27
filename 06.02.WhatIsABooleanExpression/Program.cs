using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02.WhatIsABooleanExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "The quick brown fox jumps over the lazy dog.";
            bool result = message.Contains("dog");
            Console.WriteLine(result);

            if(message.Contains("fox"))
            {
                Console.WriteLine("What does the fox say?");
            }

            Console.ReadKey();
        }
    }
}