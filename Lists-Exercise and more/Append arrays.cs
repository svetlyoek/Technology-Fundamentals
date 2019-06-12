using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split("|").Reverse().ToList();

            List<int> print = new List<int>();
            foreach (var str in numbers)
            {
                print.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.Write(string.Join(" ", print));
            Console.WriteLine();
        }
    }
}
        
    


