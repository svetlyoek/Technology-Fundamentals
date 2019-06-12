using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double area = TriangleArea(width, height);
            Console.WriteLine(area);
        }

        static double TriangleArea(int width, int height)
        {
            return width * height;
        }
    }
}
            


        
    























