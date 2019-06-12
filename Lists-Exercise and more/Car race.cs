using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            PrintWinner(numbers);

        }

        private static void PrintWinner(int[] numbers)
        {

            double leftCarSum = 0;
            double rightCarSum = 0;
            for (int left = 0; left < (numbers.Length / 2); left++)
            {

                if (numbers[left] == 0)
                {
                    leftCarSum *= 0.8;
                }
                else
                {
                    leftCarSum += numbers[left];
                }
            }
            for (int right = numbers.Length - 1; right > numbers.Length / 2; right--)
            {

                if (numbers[right] == 0)
                {
                    rightCarSum *= 0.8;
                }
                else
                {
                    rightCarSum += numbers[right];
                }
            }
            if (leftCarSum < rightCarSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftCarSum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCarSum}");
            }

        }
        
        }
    }

        
    


