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
            char symbol = char.Parse(Console.ReadLine());
            string uppercase = "upper-case";
            string lowercase = "lower-case";
            if (char.IsUpper(symbol))
            {

                Console.WriteLine(uppercase);
            }
            else if (char.IsLower(symbol))
            {

                Console.WriteLine(lowercase);

            }
        }
    }
}

    
    
    
    


