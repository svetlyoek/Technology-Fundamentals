using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            decimal sum = 0;
            while (coins != "Start")
            {
                switch (coins)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        decimal money = decimal.Parse(coins);
                        sum += money;
                        break;
                    default:

                        Console.WriteLine("Cannot accept {0}", coins);
                        break;
                }
                coins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            decimal price = 0;
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2.00m;
                        break;
                    case "Water":
                        price = 0.7m;
                        break;
                    case "Crisps":
                        price = 1.5m;
                        break;
                    case "Soda":
                        price = 0.8m;
                        break;
                    case "Coke":
                        price = 1.0m;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (sum >= price && sum > 0 && price > 0)
                {
                    Console.WriteLine("Purchased {0}", product.ToLower());
                    sum -= price;
                    price = 0;
                }
                else if (price > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    price = 0;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine("Change: {0:f2}", sum);
        }
    }
}


    
    
    
    


