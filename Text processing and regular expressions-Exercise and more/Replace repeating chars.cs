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
            sb.Append(text[0]);
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    sb.Append(text[i + 1]);
                }


            }
            Console.WriteLine(sb);
        }
                }
            }
        
    






    

