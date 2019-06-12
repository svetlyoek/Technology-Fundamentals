using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = 0.0;
            result = PrintResult(power, number, result);
            Console.WriteLine(result);

        }

        static double PrintResult(double power, double number, double result)
        {
            result = Math.Pow(number, power);
            return result;
        }
    }
}
            


        
    























