using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);

            }
            products.Sort();
            for (int j = 0; j < products.Count; j++)
            {
                Console.WriteLine($"{j + 1}.{products[j]}");
            }
        }
    }
}

