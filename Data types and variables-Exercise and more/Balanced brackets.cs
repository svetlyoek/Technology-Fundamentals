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
            int n = int.Parse(Console.ReadLine());
            int open = 0;
            int close = 0;
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    open++;
                    if (open - close > 1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (input == ")")
                {
                    close++;
                    if (open - close != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }

            }
            if (open == close)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }






        }
    }
    }



















