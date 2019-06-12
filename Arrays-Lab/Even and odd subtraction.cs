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
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    oddSum += numbers[i];
                }
            }
            result = evenSum - oddSum;
            Console.WriteLine(result);



        }
        }
    }
    



















