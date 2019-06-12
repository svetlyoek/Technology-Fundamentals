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
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int newNum = 0;
            bool number = false;
            for (int i = 1; i <= num; i++)
            {
                newNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                number = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", newNum, number);
                sum = 0;
                i = newNum;
            }
        }
    }
}

    
    
    
    


