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
            int counter = int.Parse(Console.ReadLine());
            double volume = 0;
            double bigestVolume = double.MinValue;
            string bigestKegModel = "";
            for (int i = 1; i <= counter; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = ((Math.PI * (radius * radius)) * height);



                if (volume > bigestVolume)
                {
                    bigestVolume = volume;
                    bigestKegModel = model;
                }

            }
            Console.WriteLine($"{bigestKegModel}");

        }
    }
}

















