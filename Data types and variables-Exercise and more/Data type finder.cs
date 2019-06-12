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
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    return;
                }
                int number = 0;

                char symbol = ' ';
                double floating = 0.0;
                bool isBool;

                if (int.TryParse(input, out number))
                {

                    Console.WriteLine($"{input} is integer type");

                }
                else if (char.TryParse(input, out symbol))
                {

                    Console.WriteLine($"{input} is character type");

                }
                else if (double.TryParse(input, out floating))
                {

                    Console.WriteLine($"{input} is floating point type");

                }
                else if (bool.TryParse(input, out isBool))


                {

                    Console.WriteLine($"{input} is boolean type");
                }






                else
                {
                    Console.WriteLine($"{input} is string type");
                }

            }
        }
    }
}


















