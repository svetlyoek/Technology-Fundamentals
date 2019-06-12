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
            string peopleType = Console.ReadLine();
            string dayType = Console.ReadLine();
            double price = 0;
            double discount = 0;

            if (dayType == "Friday")
            {
                if (peopleType == "Students")
                {
                    price = 8.45;
                }
                else if (peopleType == "Business")
                {
                    price = 10.90;
                }
                else if (peopleType == "Regular")
                {
                    price = 15.00;
                }
            }
            else if (dayType == "Saturday")
            {
                if (peopleType == "Students")
                {
                    price = 9.80;
                }
                else if (peopleType == "Business")
                {
                    price = 15.60;
                }
                else if (peopleType == "Regular")
                {
                    price = 20.00;
                }
            }
            else if (dayType == "Sunday")
            {
                if (peopleType == "Students")
                {
                    price = 10.46;
                }
                else if (peopleType == "Business")
                {
                    price = 16.00;
                }
                else if (peopleType == "Regular")
                {
                    price = 22.50;
                }
            }

            if (people >= 30 && peopleType == "Students")
            {


                discount = (people * price) * 0.15;
                Console.WriteLine("Total price: {0:f2}", (people * price) - discount);

            }
            else if (peopleType == "Business" && people >= 100)
            {


                people -= 10;
                Console.WriteLine("Total price: {0:f2}", people * price);
            }
            else if (peopleType == "Regular" && people >= 10 && people <= 20)
            {


                discount = (people * price) * 0.05;
                Console.WriteLine("Total price: {0:f2}", (people * price) - discount);
            }
            else
            {
                Console.WriteLine("Total price: {0:f2}", (people * price));
            }
        }
    }
    }


    
    
    
    


