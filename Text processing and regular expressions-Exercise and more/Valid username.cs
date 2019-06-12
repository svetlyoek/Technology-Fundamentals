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
            string[] text = Console.ReadLine().Split(", ").ToArray();
            bool IsValid = false;
            foreach (var item in text)
            {
                string word = item;
                if (word.Length >= 3 && word.Length <= 16)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        char element = word[i];
                        if (Char.IsLetterOrDigit(element) || element == '-' || element == '_')
                        {
                            IsValid = true;
                        }
                        else
                        {
                            IsValid = false;
                            break;
                        }

                    }
                    if (IsValid)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}





    

