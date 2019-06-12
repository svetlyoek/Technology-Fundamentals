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
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int secondNum = arr[j];
                    if (number <= secondNum)
                    {
                        break;
                    }
                    else if (j == arr.Length - 1)
                    {
                        Console.Write(number + " ");
                    }
                }

            }
            Console.WriteLine(arr[arr.Length - 1]);

        }
        }
}
    
    



















