﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {

                factorial *= i;

            }
            Console.WriteLine(factorial);

        }

    }
    }

        
    


