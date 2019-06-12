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

            var patten = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+\b)");

            MatchCollection mathed = patten.Matches(text);


            foreach (Match item in mathed)
            {
                Console.Write("{0} ", string.Join(" ", item));
            }
        }
    }
}




    

