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

            Console.Write("Length: ");
            double Length;
            Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width;
            Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height;
            Height = double.Parse(Console.ReadLine());
            double Volume;
            Volume = ((Length * Width) * Height) / 3;
            Console.Write($"Pyramid Volume: {Volume:f2}");

        }
    }
}

    
    
    
    


