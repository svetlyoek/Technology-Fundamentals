using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{

    class Catalogue
    {

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (true)
            {
                string[] text = Console.ReadLine().Split("/").ToArray();
                if (text[0] == "end")
                {
                    break;
                }
                string brand = text[1];
                string model = text[2];
                int horsePower = int.Parse(text[3]);
                int weight = int.Parse(text[3]);
                if (text[0] == "Car")
                {

                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower

                    };
                    cars.Add(car);
                }
                else if (text[0] == "Truck")
                {
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    trucks.Add(truck);
                }

            }
            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truck in trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }


    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    }


                
            
        
    



        
    


