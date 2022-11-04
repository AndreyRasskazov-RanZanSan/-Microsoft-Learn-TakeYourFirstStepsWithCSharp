using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03.Step3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            foreach(int items in inventory)
            {
                sum += items;
            }
        }
    }
}