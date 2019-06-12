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
            long number = long.Parse(Console.ReadLine());
            long temporaryNumber = 1;
            for (int i = 0; i < number; i++)
            {
                for (int g = 0; g <= i; g++)
                {

                    if (g == 0 || i == 0)
                    {
                        temporaryNumber = 1;
                        Console.Write(temporaryNumber + " ");
                    }
                    else
                    {
                        temporaryNumber = temporaryNumber * (i - g + 1) / g;
                        Console.Write(temporaryNumber + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

        
    























