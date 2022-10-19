using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.WriteCodeToExerciseCSharpOrderOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.ReadKey();
        }
    }
}