using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
            foreach (string item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}

    

