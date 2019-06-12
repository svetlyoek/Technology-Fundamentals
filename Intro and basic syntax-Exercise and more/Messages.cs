using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            int types = int.Parse(Console.ReadLine());
            string message = "";
            char character = (char)97;
            for (int i = 1; i <= types; i++)
            {
                int combination = int.Parse(Console.ReadLine());
                int digitLength = combination.ToString().Length;
                int mainDigit = combination % 10;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = (offset + digitLength - 1);
                if (mainDigit == 0)
                {
                    character = (char)32;

                }
                else
                {
                    character = (char)(character + letterIndex);
                }
                message += character;
                character = (char)97;
            }
            Console.Write(message);

            Console.WriteLine();
        }
        }
        }
    
    
    
    


