using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bomb[0];
            int bombPower = bomb[1];
            Console.WriteLine(PrintNewNumbers(numbers, bomb, bombNumber, bombPower));


        }

        private static int PrintNewNumbers(List<int> numbers, int[] bomb, int bombNumber, int bombPower)
        {
            for (int i = 0; i <= numbers.Count - 1; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    for (int j = 0; j <= bombPower; j++)
                    {
                        if (i <= numbers.Count - 1)
                        {
                            numbers.RemoveAt(i);
                        }
                    }

                    for (int k = 1; k <= bombPower; k++)
                    {
                        if (i - 1 >= 0)
                        {
                            numbers.RemoveAt(i - 1);
                            i--;
                        }
                    }

                }
            }
            numbers.RemoveAll(n => n == bombNumber);
            return numbers.Sum();
        }
        }
    }
        
    


