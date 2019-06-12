using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string item in text)
            {
                string word = item.ToLower();
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;

                }
                else
                {
                    dictionary.Add(word, 1);
                }

            }

            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {


                    Console.Write(item.Key + " ");
                }
            }
            Console.WriteLine();
        }
        }
    }

    

