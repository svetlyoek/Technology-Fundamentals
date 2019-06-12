﻿using System;
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
            int[] firstArray = new int[counter];
            int[] secondArray = new int[counter];

            for (int i = 0; i < counter; i++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


                if (i % 2 == 0)
                {
                    firstArray[i] = array[0];
                    secondArray[i] = array[1];
                }
                else
                {
                    firstArray[i] = array[1];
                    secondArray[i] = array[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));


        }
        }
}
    
    



















