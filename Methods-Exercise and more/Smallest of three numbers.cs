using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintSmallestNumber(firstNumber, secondNumber, thirdNumber));
        }

        static int PrintSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int minFromTwo = Math.Min(firstNumber, secondNumber);
            int minFromLastTwo = Math.Min(secondNumber, thirdNumber);
            int smallestNumber = Math.Min(minFromLastTwo, minFromTwo);
            return smallestNumber;
        }
    }
}


































