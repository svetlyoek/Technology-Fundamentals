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
            double pounds = double.Parse(Console.ReadLine());
            double dollars = pounds * 1.31;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
    
    
    
    


