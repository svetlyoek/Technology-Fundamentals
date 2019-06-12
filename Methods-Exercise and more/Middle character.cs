using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MiddleCharPrint(text);
        }

        private static void MiddleCharPrint(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write($"{text[text.Length / 2 - 1]}{text[text.Length / 2]}");
                Console.WriteLine();
            }
            else
            {
                Console.Write($"{text[text.Length / 2]}");
                Console.WriteLine();
            }
        }
    }
}


































