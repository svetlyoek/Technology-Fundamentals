using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int even = GetSumOfEvenDigits(number);
            int odd = GetSumOfOddNumbers(number);

            Console.WriteLine(even * odd);
        }

        static int GetSumOfEvenDigits(int number)
        {

            int evenSum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }

            }
            return evenSum;
        }

        static int GetSumOfOddNumbers(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }

            }
            return oddSum;

        }
    }
}
            


        
    























