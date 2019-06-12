using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime newDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(newDate.DayOfWeek);

        }

    }
    }

        
    


