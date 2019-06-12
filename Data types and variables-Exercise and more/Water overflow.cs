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
            int capacity = 255;
            int filledLiters = 0;
            int leftLiters = capacity;
            for (int i = 1; i <= counter; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (leftLiters - liters >= 0)
                {
                    leftLiters -= liters;

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            filledLiters = capacity - leftLiters;
            Console.WriteLine($"{filledLiters}");
        }
                }
            }
        
    


    

    



    
    
    
    


