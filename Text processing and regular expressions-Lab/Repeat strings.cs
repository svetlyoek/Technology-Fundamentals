using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (var item in arr)
            {
                int counter = 0;
                counter = item.Length;
                for (int i = 0; i < item.Length; i++)
                {
                    sb.Append(item);
                }
            }
            Console.WriteLine(sb);
        }
        }
    }




    

