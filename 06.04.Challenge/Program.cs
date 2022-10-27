using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._04.Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if(daysUntilExpiration <= 10)
            {
                if(daysUntilExpiration <= 5)
                {
                    if (daysUntilExpiration <= 1)
                    {
                        if (daysUntilExpiration == 0)
                        {
                            Console.WriteLine("Your subscription has expired.");
                        }
                        else
                        {
                            Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
                    }
                }
                else
                {
                    Console.WriteLine("Your subscription will expire soon. Renew now!");
                }
            }

            Console.WriteLine(daysUntilExpiration);
            Console.ReadKey();
        }
    }
}