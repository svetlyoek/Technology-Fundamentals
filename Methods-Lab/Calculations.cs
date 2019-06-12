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
            string operation = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    PrintAdd(num, num2);
                    break;
                case "subtract":
                    PrintSubtract(num, num2);
                    break;
                case "divide":
                    PrintDivide(num, num2);
                    break;
                case "multiply":
                    PrintMultiply(num, num2);
                    break;
            }
        }

        static void PrintAdd(int num, int num2)
        {
            Console.WriteLine(num + num2);
        }

        static void PrintMultiply(int num, int num2)
        {
            Console.WriteLine(num * num2);

        }



        static void PrintSubtract(int num, int num2)
        {
            Console.WriteLine(num - num2);
        }

        static void PrintDivide(int num, int num2)
        {
            Console.WriteLine(num / num2);
        }

    }
}

        
    























