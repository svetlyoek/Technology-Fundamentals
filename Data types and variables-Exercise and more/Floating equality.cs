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
            double first = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());
            double max = Math.Max(first, last);
            double min = Math.Min(first, last);
            double result = max - min;


            if (result == 0.000001 || result > 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }



        }
    }
    }



















