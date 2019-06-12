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
            List<string> names = new List<string>();
            Dictionary<string, List<string>> modules = new Dictionary<string, List<string>>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] text = command.Split(" : ").ToArray();
                string module = text[0];
                string name = text[1];
                if (!modules.ContainsKey(module))
                {
                    modules.Add(module, names);
                    names.Add(name);
                    names = new List<string>();

                }
                else
                {
                    modules[module].Add(name);
                }

            }
            foreach (var item in modules.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var kvp in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
        }
    }
}

    

