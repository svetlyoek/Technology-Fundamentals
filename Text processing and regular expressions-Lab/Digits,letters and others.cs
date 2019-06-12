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

            string text = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder chars = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (Char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }
                else
                {
                    chars.Append(text[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
        }
        }
    }




    

