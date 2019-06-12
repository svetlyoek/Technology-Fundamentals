using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            PrintElementsInRange(first, second);

        }

        static void PrintElementsInRange(char first, char second)
        {
            if (second < first)
            {
                char temp = second;
                second = first;
                first = temp;
            }
        }
    }
}


































