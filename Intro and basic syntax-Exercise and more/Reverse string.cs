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

            string str = "", reverse = "";
            int Length = 0;


            str = Console.ReadLine();

            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }

            Console.WriteLine("{0}", reverse);
        }
        }
        }
    
    
    
    


