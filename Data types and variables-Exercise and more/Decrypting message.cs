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
            int key = int.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());
            int asciiNumber = 0;
            string print = "";

            for (int i = 1; i <= counter; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                asciiNumber = (int)symbol + key;
                print += (char)asciiNumber;
            }

            Console.Write(print);
            Console.WriteLine();
        




        }
    }
    }



















