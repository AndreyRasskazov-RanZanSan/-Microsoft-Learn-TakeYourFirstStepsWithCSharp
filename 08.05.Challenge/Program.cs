﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._05.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog.";

            // convert the message into a char array
            char[] charMessage = str.ToCharArray();

            // Reverse the chars
            Array.Reverse(charMessage);
            int x = 0;
            // count the o's
            foreach (char i in charMessage)
            {
                if(i == 'o')
                {
                    x++;
                }
            }

            // convert it back to a string
            string new_message = new String(charMessage);
            // print it out

            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");

            Console.ReadKey();
        }
    }
}