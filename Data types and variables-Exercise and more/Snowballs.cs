using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsNumber = int.Parse(Console.ReadLine());

            BigInteger snowballValue = 0;


            int snow = 0;
            int time = 0;
            int quality = 0;

            for (int i = 1; i <= snowballsNumber; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger currentSnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);



                if (currentSnowballValue > snowballValue)
                {

                    snowballValue = currentSnowballValue;
                    time = snowballTime;
                    quality = snowballQuality;
                    snow = snowballSnow;

                }
            }

            Console.WriteLine($"{snow} : {time} = {snowballValue} ({quality})");
        }
    }
    }


















