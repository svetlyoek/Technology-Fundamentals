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
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 1; i <= counter; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "register")
                {
                    string name = command[1];
                    string number = command[2];
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, number);
                        Console.WriteLine($"{name} registered {number} successfully");

                    }
                    else
                    {

                        Console.WriteLine($"ERROR: already registered with plate number {number}");

                    }
                }
                else if (command[0] == "unregister")
                {
                    string name = command[1];
                    if (!dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");

                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        dict.Remove(name);
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            }
        }
    }


    

