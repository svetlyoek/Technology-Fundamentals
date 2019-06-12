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
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            int years = centuries * 100;

            int days = (int)(years * 365.2422);

            int hours = (days * 24);
            double minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
    
    
    
    


