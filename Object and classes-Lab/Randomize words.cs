using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            Random rnd = new Random();

            for (int i = 0; i < text.Count; i++)
            {
                int first = rnd.Next(text.Count);
                int second = rnd.Next(text.Count);
                string changer = text[first];
                text[first] = text[second];
                text[second] = changer;
            }
            Console.WriteLine(string.Join("\n", text));

        }

    }
    }

        
    


