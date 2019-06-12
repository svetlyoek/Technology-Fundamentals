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

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] numbers = new int[] { a, b, c };
            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (int value in numbers)
            {
                Console.WriteLine($"{value}");


            }
        }
    }
    }
    
    


