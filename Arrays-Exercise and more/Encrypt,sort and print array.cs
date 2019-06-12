using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] array = new int[numbersCount];



            int length = 0;
            char[] digitOfName;

            for (int i = 0; i < numbersCount; i++)
            {
                string name = Console.ReadLine();
                length = name.Length;
                digitOfName = name.ToArray();
                int sum = 0;
                for (int j = 0; j < digitOfName.Length; j++)
                {
                    if (digitOfName[j] == 'a' || digitOfName[j] == 'u' || digitOfName[j] == 'e' || digitOfName[j] == 'o' || digitOfName[j] == 'i'
                        || digitOfName[j] == 'A' || digitOfName[j] == 'U' || digitOfName[j] == 'E' || digitOfName[j] == 'O' || digitOfName[j] == 'I')
                    {
                        sum += (digitOfName[j] * name.Length);
                    }
                    else
                    {
                        sum += (digitOfName[j] / name.Length);
                    }
                }
                array[i] = sum;
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }

            }

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}

        
    























