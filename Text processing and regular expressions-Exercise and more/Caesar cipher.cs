using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = (char)text[i];
                sb.Append((char)(symbol + 3));
            }
            Console.WriteLine(sb);
        }
                }
            }
        
    






    

