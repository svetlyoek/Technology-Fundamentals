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
            SortedDictionary<string, List<string>> dict = new SortedDictionary<string, List<string>>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] text = command.Split(" -> ").ToArray();
                string companyName = text[0];
                string employee = text[1];
                if (!dict.ContainsKey(companyName))
                {
                    dict.Add(companyName, new List<string>());
                    dict[companyName].Add(employee);
                }
                else
                {
                    dict[companyName].Add(employee);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var element in item.Value.Distinct())
                {

                    Console.WriteLine($"-- {element}");
                }
            }
        }
    }
}


    

