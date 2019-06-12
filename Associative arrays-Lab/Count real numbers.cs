using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedDictionary<int, int> print = new SortedDictionary<int, int>();
            foreach (var element in numbers)
            {
                if (print.ContainsKey(element))
                {
                    print[element]++;
                }
                else
                {
                    print[element] = 1;
                }
            }
            foreach (var element in print)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
    

