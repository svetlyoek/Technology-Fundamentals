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
            List<Box> text = new List<Box>();
            while (true)
            {
                List<string> data = Console.ReadLine().Split().ToList();
                if (data[0] == "end")
                {
                    break;
                }
                string number = data[0];
                string itemName = data[1];
                int quantity = int.Parse(data[2]);
                double price = double.Parse(data[3]);
                Box box = new Box();
                {
                    box.SerialNumber = number;
                    box.Item.Name = itemName;
                    box.ItemQuantity = quantity;
                    box.Item.Price = price;
                    box.PriceBox = price * quantity;
                }
                text.Add(box);

            }
            var printList = text.OrderByDescending(x => x.PriceBox);
            foreach (Box box in printList)
            {

                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${(box.Item.Price):f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${(box.PriceBox):f2}");
            }

        }
        class Box
        {
            public Box()
            {
                Item = new Item();
            }

            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceBox { get; set; }
        }
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }
}
                
            
        
    



        
    


