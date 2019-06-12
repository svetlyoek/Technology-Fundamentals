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
            int counter = int.Parse(Console.ReadLine());

            for (int i = 1; i <= counter; i++)
            {
                string numbers = Console.ReadLine();
                char space = ' ';
                string[] splitNumbers = numbers.Split(space);
                long leftNumbers = long.Parse(splitNumbers[0]);
                long rightNumbers = long.Parse(splitNumbers[1]);
                long bigerNumbers = leftNumbers;
                if (rightNumbers > leftNumbers)
                {
                    bigerNumbers = rightNumbers;
                }
                long sum = 0;
                while (bigerNumbers != 0)
                {
                    sum += bigerNumbers % 10;
                    bigerNumbers = bigerNumbers / 10;
                }

                Console.WriteLine($"{Math.Abs(sum)}");


            }
        }
    }
}


















