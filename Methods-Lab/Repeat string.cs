using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());
            Console.WriteLine(NewText(text, counter));

        }

        static string NewText(string text, int counter)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                result.Append(text);
            }
            return result.ToString();

        }
    }
}
            


        
    























