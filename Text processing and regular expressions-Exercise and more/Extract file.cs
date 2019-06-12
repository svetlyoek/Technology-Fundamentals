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

            int startIndexOfFile = text.LastIndexOf('\\') + 1;
            string file = text.Substring(startIndexOfFile);
            int startIndexOfExtension = file.LastIndexOf('.') + 1;

            string fileName = file.Substring(0, startIndexOfExtension - 1);
            string extensionName = file.Substring(startIndexOfExtension);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extensionName}");
        }
                }
            }
        
    






    

