using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mixedNumbers = new List<int>();

            FindElementsToPrint(firstNumbers, secondNumbers, mixedNumbers);

        }


        private static void FindElementsToPrint(List<int> firstNumbers, List<int> secondNumbers, List<int> mixedNumbers)
        {
            int firstNumber = 0;
            int secondNumber = 0;


            if (firstNumbers.Count > secondNumbers.Count)
            {
                firstNumber = firstNumbers[firstNumbers.Count - 2];
                secondNumber = firstNumbers[firstNumbers.Count - 1];



            }
            else
            {
                firstNumber = secondNumbers[1];
                secondNumber = secondNumbers[0];
            }
            int maxNumber = Math.Max(firstNumber, secondNumber);
            int minNumber = Math.Min(firstNumber, secondNumber);
            mixedNumbers.AddRange(firstNumbers.Where(element => element < maxNumber && element > minNumber));
            mixedNumbers.AddRange(secondNumbers.Where(element => element < maxNumber && element > minNumber));

            mixedNumbers.Sort();
            Console.Write(String.Join(" ", mixedNumbers));
            Console.WriteLine();


        }

    }
    }

        
    


