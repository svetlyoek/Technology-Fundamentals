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
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (double number in array)
            {
                int rounded = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", number, rounded);
            }
        }




    }
    }
    



















