using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}

    

