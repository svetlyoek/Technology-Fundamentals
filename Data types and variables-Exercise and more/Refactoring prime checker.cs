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
            for (int i = 2; i <= counter; i++)
            {
                string prime = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, prime);
            }




        }
    }
    }



















