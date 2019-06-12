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
            long power = long.Parse(Console.ReadLine());
            long distance = long.Parse(Console.ReadLine());
            long exhaustion = long.Parse(Console.ReadLine());

            int counter = 0;
            decimal halfPower = (decimal)(power * 0.50);
            while (power >= distance)
            {
                power -= distance;
                counter++;
                if (power == halfPower && exhaustion > 0)
                {
                    power /= exhaustion;
                }

            }



            Console.WriteLine($"{power}");
            Console.WriteLine($"{counter}");
        }
    }
    }


















