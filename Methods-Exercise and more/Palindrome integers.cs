using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                string number = command;
                if (command == "END")
                {
                    break;
                }
                command = Console.ReadLine();
                CheckPalindrome(number);
            }
        }

        private static void CheckPalindrome(string number)
        {
            string palindrome = " ";
            string reversedPalindrome = " ";
            for (int i = 0; i < number.Length; i++)
            {
                palindrome += number[i];
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedPalindrome += number[i];
            }
            if (reversedPalindrome == palindrome)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
    }



































