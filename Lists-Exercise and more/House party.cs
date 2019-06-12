﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int guestsCounter = int.Parse(Console.ReadLine());
            List<string> print = new List<string>();
            for (int i = 1; i <= guestsCounter; i++)
            {
                List<string> message = Console.ReadLine().Split().ToList();
                if (message.Count == 3)
                {
                    if (print.Contains(message[0]))
                    {
                        Console.WriteLine($"{message[0]} is already in the list!");
                    }
                    else
                    {
                        print.Add(message[0]);
                    }

                }
                else if (message.Count == 4)
                {
                    if (print.Contains(message[0]))
                    {
                        print.Remove(message[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{message[0]} is not in the list!");
                    }
                }

            }
            foreach (string item in print)
            {


                Console.WriteLine(item);
            }
            }
    }
        }
    


