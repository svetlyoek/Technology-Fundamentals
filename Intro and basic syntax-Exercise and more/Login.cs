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
            char[] user = Console.ReadLine().Reverse().ToArray();
            int passCount = 0;

            while (passCount != 4)
            {
                passCount++;
                char[] pass = Console.ReadLine().ToArray();


                if (string.Join("", pass) == string.Join("", user))
                {
                    Console.WriteLine($"User {String.Join("", user.Reverse())} logged in.");
                    return;
                }
                else if (passCount != 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            Console.WriteLine($"User {String.Join("", user.Reverse())} blocked!");
        }
    }
}


    
    
    
    


