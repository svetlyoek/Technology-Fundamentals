using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = 0;
            switch (product)
            {
                case "coffee":
                    CoffePrice(price, quantity);
                    break;
                case "water":
                    WaterPrice(price, quantity);
                    break;
                case "coke":
                    CokePrice(price, quantity);
                    break;
                case "snacks":
                    SnacksPrice(price, quantity);
                    break;
            }
        }

        static void CoffePrice(decimal price, int quantity)
        {
            price = quantity * 1.50m;
            Console.WriteLine($"{(quantity * 1.50):f2}");
        }

        static void WaterPrice(decimal price, int quantity)
        {
            price = quantity * 1.00m;
            Console.WriteLine($"{(quantity * 1.00):f2}");
        }

        static void CokePrice(decimal price, int quantity)
        {
            price = quantity * 1.40m;
            Console.WriteLine($"{(quantity * 1.40):f2}");
        }


        static void SnacksPrice(decimal price, int quantity)
        {
            price = quantity * 2.00m;
            Console.WriteLine($"{(quantity * 2.00):f2}");
        }
    }
        }
            


        
    























