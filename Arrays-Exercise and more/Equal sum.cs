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
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                rightSum += arr[i];
            }
            for (int j = 0; j < arr.Length; j++)
            {
                rightSum -= arr[j];
                if (rightSum == leftSum)
                {
                    Console.WriteLine(j);
                    return;
                }
                leftSum += arr[j];
            }
            Console.WriteLine("no");
        }


    }
}

    
    



















