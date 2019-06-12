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
            int multiplier = int.Parse(Console.ReadLine());

            do
            {



                Console.WriteLine("{0} X {1} = {2}", n, multiplier, n * multiplier);
                multiplier++;
            }


            while (multiplier <= 10);
            return;

        }

    }
    }
    


