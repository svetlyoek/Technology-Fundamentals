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
            int counter = int.Parse(Console.ReadLine());
            Triangle(counter);
        }

        static void Triangle(int counter)
        {
            for (int row = 1; row <= counter; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();

            }
            for (int k = counter - 1; k >= 1; k--)
            {
                for (int l = 1; l <= k; l++)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }
        }
            }
}

        
    























