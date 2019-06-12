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
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            string first = char.ToString(one);
            string second = char.ToString(two);
            string third = char.ToString(three);
            string print = ($"{first}{second}{third}");

            Console.WriteLine(print);

        }
    }
    }

    
    
    
    


