using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            while (true)
            {

                if (n % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", Math.Abs(n));


        }

    }
    }
    


