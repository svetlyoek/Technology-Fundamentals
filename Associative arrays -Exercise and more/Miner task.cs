using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            int counter = 0;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while ((command = Console.ReadLine()) != "stop")
            {

                int quantity = int.Parse(Console.ReadLine());
                counter++;

                if (!dict.ContainsKey(command))
                {
                    dict.Add(command, quantity);
                }
                else
                {
                    dict[command] += quantity;
                }

            }







            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

    

