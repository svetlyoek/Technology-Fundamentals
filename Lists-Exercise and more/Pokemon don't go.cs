using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            PrintElements(numbers);


        }

        private static void PrintElements(List<int> numbers)
        {
            int sum = 0;
            while (numbers.Count > 0)
            {

                int index = int.Parse(Console.ReadLine());

                int changeValue = 0;
                if (index < 0)
                {

                    changeValue = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];

                }
                else if (index > numbers.Count - 1)
                {

                    changeValue = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];


                }
                else
                {
                    changeValue = numbers[index];
                    numbers.RemoveAt(index);
                }


                for (int i = 0; i < numbers.Count; i++)
                {


                    if (numbers[i] <= changeValue)
                    {
                        numbers[i] += changeValue;
                    }
                    else
                    {
                        numbers[i] -= changeValue;
                    }
                }

                sum += changeValue;

            }



            Console.WriteLine(sum);
        }
    }
}
        
    


