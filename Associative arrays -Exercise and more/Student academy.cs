using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> results = new Dictionary<string, List<double>>();

            for (int i = 0; i < counter; i++)
            {

                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!results.ContainsKey(name))
                {



                    results.Add(name, new List<double>());
                    results[name].Add(grade);
                }
                else
                {

                    results[name].Add(grade);

                }

            }

            foreach (var item in results.OrderByDescending(x => x.Value.Average()))
            {

                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value.OrderByDescending(x => x).Average());
                }
            }
        }
    }
}


    

