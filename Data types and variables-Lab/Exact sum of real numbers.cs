using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= counter; i++)
            {

                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
    
    
    
    


