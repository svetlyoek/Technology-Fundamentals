using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, double[]> dict = new Dictionary<string, double[]>();
            while ((command = Console.ReadLine()) != "buy")
            {

                string[] text = command.Split().ToArray();

                string product = text[0];
                double price = double.Parse(text[1]);
                int quantity = int.Parse(text[2]);
                if (!dict.ContainsKey(product))
                {
                    dict.Add(product, new double[2]);
                }
                dict[product][0] = price;
                dict[product][1] += quantity;



            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}

    

