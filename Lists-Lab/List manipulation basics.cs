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
                switch (operation[0])
                {
                    case "Add":
                        int addNumber = int.Parse(operation[1]);
                        numbers.Add(addNumber);
                        break;
                    case "Remove":
                        int removeNumber = int.Parse(operation[1]);
                        numbers.Remove(removeNumber);
                        break;
                    case "RemoveAt":
                        int removeAtIndex = int.Parse(operation[1]);
                        numbers.RemoveAt(removeAtIndex);
                        break;
                    case "Insert":
                        int insertNumber = int.Parse(operation[1]);
                        int insertIndex = int.Parse(operation[2]);
                        numbers.Insert(insertIndex, insertNumber);
                        break;
                }

            }
            Console.Write(String.Join(" ", numbers));
            Console.WriteLine();
        }
    }
        }
    


