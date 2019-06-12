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
            string[] text = Console.ReadLine().Split().ToArray();
            string firstWord = text[0];
            string secondWord = text[1];
            string longestWord = string.Empty;
            string shortestWord = string.Empty;
            int sum = 0;
            if (firstWord.Length >= secondWord.Length)
            {

                longestWord = firstWord;
                shortestWord = secondWord;
            }
            else if (secondWord.Length > firstWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }
            for (int i = 0; i < shortestWord.Length; i++)
            {
                sum += shortestWord[i] * longestWord[i];
            }
            if (shortestWord.Length != longestWord.Length)
            {
                for (int j = shortestWord.Length; j < longestWord.Length; j++)
                {
                    sum += longestWord[j];
                }
            }
            Console.WriteLine(sum);
        }
                }
            }
        
    






    

