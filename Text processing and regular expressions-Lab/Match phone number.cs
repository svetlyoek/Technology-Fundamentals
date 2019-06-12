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
            string pattern = @"\+359([ -])2(\1)\d{3}(\1)\d{4}\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            List<string> phones = new List<string>();
            foreach (Match match in matches)
            {
                phones.Add(match.ToString());
            }
            Console.Write(string.Join(", ", phones));
            Console.Write("\n");
        }
        }
    }





    

