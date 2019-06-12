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
            string command = string.Empty;
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] operation = command.Split();

                if (operation[0] == "Delete")
                {
                    int numberToDelete = int.Parse(operation[1]);
                    numbers.RemoveAll(element => element == numberToDelete);
                }
                else if (operation[0] == "Insert")
                {
                    int numberToInsert = int.Parse(operation[1]);
                    int indexToInsert = int.Parse(operation[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
            }
            Console.Write(String.Join(" ", numbers));
            Console.WriteLine();
        }
    }
        }
    


