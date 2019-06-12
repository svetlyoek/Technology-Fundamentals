using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            for (int i = 1; i <= counter; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dictionary.ContainsKey(word))
                {

                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(synonym);

            }
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key} - {string.Join(", ", element.Value)}");
            }
        }
    }
}

    

