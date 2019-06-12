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
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    for (int k = 0; k < counter; k++)
                    {
                        char first = (char)('a' + i);
                        char second = (char)('a' + j);
                        char third = (char)('a' + k);
                        Console.Write($"{first}{second}{third}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

    

    



    
    
    
    


