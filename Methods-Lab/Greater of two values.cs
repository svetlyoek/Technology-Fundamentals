using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            switch (value)
            {
                case "int":
                    int input = int.Parse(Console.ReadLine());
                    int input2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(PrintMaxInt(input, input2));
                    break;
                case "char":
                    char inputchar = char.Parse(Console.ReadLine());
                    char inputchar2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(PrintMaxChar(inputchar, inputchar2));
                    break;
                case "string":
                    string inputstring = Console.ReadLine();
                    string inputstring2 = Console.ReadLine();
                    Console.WriteLine(PrintMaxString(inputstring, inputstring2));
                    break;
            }
        }

        static int PrintMaxInt(int input, int input2)
        {
            int result = 0;
            if (input > input2)
            {
                result = input;
            }
            else if (input2 > input)
            {
                result = input2;
            }
            return result;
        }

        static char PrintMaxChar(char inputchar, char inputchar2)
        {
            char result = ' ';
            if (inputchar > inputchar2)
            {
                result = inputchar;
            }
            else if (inputchar2 > inputchar)
            {
                result = inputchar2;
            }
            return result;
        }

        static string PrintMaxString(string inputstring, string inputstring2)
        {
            string result = "";

            if (inputstring.CompareTo(inputstring2) >= 0)
            {
                result = inputstring;
            }
            else
            {
                result = inputstring2;
            }
            return result;

        }
    }
}
            


        
    























