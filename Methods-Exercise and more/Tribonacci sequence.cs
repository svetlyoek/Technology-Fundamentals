using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[number + 1];
            arr[0] = 0;
            PrintTribonacciSequence(number, arr);
        }

        private static void PrintTribonacciSequence(int number, int[] arr)
        {


            for (int i = 1; i < arr.Length; i++)
            {
                if (i <= 2)
                {
                    arr[i] = 1;
                }
            }
        }
    }
}
    
    



































