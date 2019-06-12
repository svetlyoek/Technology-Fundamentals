using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            FactorialCalculation(firstNumber, secondNumber);

        }

        private static void FactorialCalculation(long firstNumber, long secondNumber)
        {
            long firstFactorial = 1;
            long secondFactorial = 1;
            for (long i = 1; i <= firstNumber; i++)
            {
                firstFactorial *= i;
            }
            for (long i = 1; i <= secondNumber; i++)
            {
                secondFactorial *= i;
            }
            double result = (double)firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
        }
        }
    }



































