using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            PrintPositiveOrNegative(num, num2, num3);
        }

        private static void PrintPositiveOrNegative(double num, double num2, double num3)
        {
            if (num == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else if (num > 0 && num2 > 0 && num3 > 0 || num < 0 && num2 < 0 && num3 > 0
                || num > 0 && num2 < 0 && num3 < 0 || num < 0 && num2 > 0 && num3 < 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
            }
        }
    }

    
    



































