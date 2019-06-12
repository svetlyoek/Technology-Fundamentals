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

            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= stop; i++)
            {
                sum += i;
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}


    
    
    
    


