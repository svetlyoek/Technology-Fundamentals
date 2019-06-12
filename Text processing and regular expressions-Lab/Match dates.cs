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

            var text = Console.ReadLine();

            string pattern = (@"\b(?<days>\d{2})([.\/-])(?<months>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            MatchCollection matched = Regex.Matches(text, pattern);
            foreach (Match item in matched)
            {
                var day = item.Groups["days"].Value;
                var month = item.Groups["months"].Value;
                var year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}




    

