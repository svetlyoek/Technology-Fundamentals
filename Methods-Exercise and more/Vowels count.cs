using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(PrintVowelsInText(text));
        }

        static int PrintVowelsInText(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'o' || text[i] == 'u' || text[i] == 'e' || text[i] == 'i' ||
                    text[i] == 'A' || text[i] == 'O' || text[i] == 'U' || text[i] == 'E' || text[i] == 'I')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}


































