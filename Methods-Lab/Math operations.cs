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
            int firstNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case '/':
                    Console.WriteLine(DivideResult(firstNumber, secondNumber));
                    break;
                case '*':
                    Console.WriteLine(MultiplyResult(firstNumber, secondNumber));
                    break;
                case '-':
                    Console.WriteLine(SubtractResult(firstNumber, secondNumber));
                    break;
                case '+':
                    Console.WriteLine(AddResult(firstNumber, secondNumber));
                    break;

            }

        }

        static int DivideResult(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }

        static int MultiplyResult(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        static int SubtractResult(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }

        static int AddResult(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
    }

            


        
    























