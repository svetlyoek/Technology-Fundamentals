using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().Where(x => x != ' ').ToArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var item in text)
            {


                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary[item] = 1;
                }

            }
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}

    

