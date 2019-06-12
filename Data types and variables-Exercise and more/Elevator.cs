using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = people / capacity;
            if (people % capacity != 0)
            {
                courses++;
            }
            Console.WriteLine($"{courses}");
        }
    }
}

    

    



    
    
    
    


