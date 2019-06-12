using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            TopNumber(number);
        }

        private static void TopNumber(int number)
        {

            for (int i = 1; i <= number; i++)
            {

                int lastDigit = i % 10;
                int prelast = (i / 10) % 10;
                int middle = (i / 100) % 10;
                int second = (i / 1000) % 10;
                int first = (i / 10000) % 10;
                int sum = lastDigit + prelast + middle + second + first;
                if (sum % 8 == 0)
                {
                    if (lastDigit % 2 == 1 || prelast % 2 == 1 || middle % 2 == 1 || second % 2 == 1 || first % 2 == 1)
                    {
                        Console.WriteLine(i);

                    }
                }
            }
        }
    }
    }



































