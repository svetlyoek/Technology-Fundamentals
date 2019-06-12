using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split().ToList();
            string inputTexts = Console.ReadLine();
            List<string> letters = inputTexts.Select(c => c.ToString()).ToList();
            List<string> finalResult = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int sumOfdigits = 0;
                foreach (var symbol in numbers[i])
                {
                    int digit = symbol - '0';
                    sumOfdigits += digit;
                }
                if (sumOfdigits >= letters.Count)
                {
                    sumOfdigits = sumOfdigits % (letters.Count);
                }
                finalResult.Add(letters[sumOfdigits]);
                letters.RemoveAt(sumOfdigits);
            }
            Console.WriteLine(string.Join("", finalResult));

        }


        
        }
    }

        
    


