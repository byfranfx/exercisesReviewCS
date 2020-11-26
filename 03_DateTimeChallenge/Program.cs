﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date
            Console.Write("Give me a date: ");
            string previousDateString = Console.ReadLine();

            Console.Write("What date format do you want to use: ");
            string dateFormat = Console.ReadLine();

            if (dateFormat.Length < 1)
            {
                dateFormat = "M/d/yy";
            }

            DateTime previousDate = DateTime.ParseExact(previousDateString, dateFormat, null);

            TimeSpan fromPreviousDate = DateTime.Now.Subtract(previousDate);

            if (fromPreviousDate.Ticks < 0) {
                Console.WriteLine($"{ previousDateString } is { Math.Round(-fromPreviousDate.TotalDays, 0, MidpointRounding.AwayFromZero) } days in the future.");
            } else
            {
                Console.WriteLine($"It has been { Math.Round(fromPreviousDate.TotalDays, 0, MidpointRounding.AwayFromZero) } days since { previousDateString }");
            }

            //Console.WriteLine($"It has been { fromPreviousDate.Days} since { previousDateString }");

            Console.WriteLine("\r\n" + "Press enter to continue¬");
            Console.ReadLine();



            // Time
            Console.Write("Give me a time: ");
            string previousTimeString = Console.ReadLine();

            Console.Write("What time format do you want to use: ");
            string timeformat = Console.ReadLine();

            DateTime previousTime = DateTime.ParseExact(previousTimeString, "h:mm tt", CultureInfo.InvariantCulture);
            //new CultureInfo("en-US")
            //CultureInfo.InvariantCulture

            TimeSpan fromPreviousTime = DateTime.Now.Subtract(previousTime);

            if (fromPreviousTime.Ticks < 0)
            {
                fromPreviousTime = fromPreviousTime.Add(TimeSpan.FromHours(24));
            }

            Console.WriteLine($"{ previousTimeString } was { fromPreviousTime.Hours } hours and { fromPreviousTime.Minutes } minutes ago.");

            Console.ReadLine();

        }
    }
}
