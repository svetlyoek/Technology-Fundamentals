using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var input = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int result = int.Parse(input);
                    Console.WriteLine(result * 2);
                    break;
                case "real":
                    double result2 = double.Parse(input);
                    Console.WriteLine($"{(result2 * 1.5):f2}");
                    break;
                case "string":

                    Console.WriteLine('$' + input + '$');
                    break;
            }
                }
            }
        }
    
    



































