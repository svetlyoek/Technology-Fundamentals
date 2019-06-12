using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        private static void PrintTriangle(int number)
        {
            for (int rows = 1; rows <= number; rows++)
            {
                for (int cols = 1; cols <= number; cols++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


































