using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                string symbols = new string('*', item.Length);
                text = text.Replace(item, symbols);
            }
            Console.WriteLine(text);
        }
        }
    }




    

