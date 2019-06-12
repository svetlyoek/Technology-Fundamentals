using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n * 2; i += 2)

            {

                Console.WriteLine("{0}", i);

                sum += i;
            }
            Console.WriteLine("Sum: {0}", sum);

        }
    }
    }


