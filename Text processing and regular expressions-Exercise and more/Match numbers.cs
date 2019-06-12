using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            MatchCollection result = Regex.Matches(text, pattern);
            foreach (Match matches in result)
            {
                Console.Write(matches + " ");
            }
            Console.WriteLine("\n");
        }
                }
            }
        
    






    

