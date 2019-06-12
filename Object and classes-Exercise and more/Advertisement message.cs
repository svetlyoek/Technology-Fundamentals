using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            string[] phrases ={"Excellent product.", "Such a great product.",
                    "I always use that product.", "Best product of its category.",
                    "Exceptional product.", "I can’t live without this product."};
            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random rand = new Random();
            for (int i = 0; i < counter; i++)
            {
                int randomPhrase = rand.Next(phrases.Length);

                int randomEvents = rand.Next(events.Length);

                int randomAuthors = rand.Next(authors.Length);

                int randomCity = rand.Next(city.Length);

                Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvents]} {authors[randomAuthors]} – {city[randomCity]}.");

            }
        }
    }
}


                
            
        
    



        
    


