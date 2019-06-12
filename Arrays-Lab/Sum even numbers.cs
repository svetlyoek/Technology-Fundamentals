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
            int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {

                if (number[i] % 2 == 0)
                {
                    sum += number[i];
                }
            }
            Console.WriteLine(sum);
        }




    }
    }
    



















