using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(FinalPrint(number, number2, number3));

        }

        static int FinalPrint(int number, int number2, int number3)
        {
            int result = (number + number2) - number3;
            return result;
        }
    }
}


































