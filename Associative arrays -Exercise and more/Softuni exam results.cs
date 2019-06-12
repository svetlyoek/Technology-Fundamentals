using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, int> namesAndScores = new Dictionary<string, int>();
            Dictionary<string, int> techAndCounts = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "exam finished")
            {
                List<string> text = command.Split("-").ToList();
                if (text[1] == "banned")
                {
                    namesAndScores.Remove(text[0]);
                }
                else
                {
                    int number = int.Parse(text[2]);
                    if (!namesAndScores.ContainsKey(text[0]))
                    {

                        namesAndScores[text[0]] = number;
                    }
                    else if (number > namesAndScores[text[0]])
                    {
                        namesAndScores[text[0]] = number;
                    }
                    if (!techAndCounts.ContainsKey(text[1]))
                    {
                        techAndCounts[text[1]] = 0;
                    }
                    techAndCounts[text[1]]++;



                }
            }
            Console.WriteLine("Results:");
            foreach (var item in namesAndScores.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in techAndCounts.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            }
        }
    }



    

