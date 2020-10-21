using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capture data from console calculate how many days ago it was.
            /*Console.Write("Give me a date: ");
            string previousDateString = Console.ReadLine();

            DateTime previousDate = DateTime.ParseExact(previousDateString, "m/d/yy", null);

            TimeSpan fromPreviousDate = DateTime.Now.Subtract(previousDate);

            Console.WriteLine($"It has been { fromPreviousDate.Days} since { previousDateString }");

            Console.ReadLine();*/

            Console.Write("Give me a time: ");
            string previousTimeString = Console.ReadLine();

            DateTime previousTime = DateTime.ParseExact(previousTimeString, "h:mm tt", null);

            TimeSpan fromPreviousTime = DateTime.Now.Subtract(previousTime);

            Console.WriteLine($"{ previousTimeString } was { fromPreviousTime.Hours } hours and { fromPreviousTime.Minutes } minutes ago.");

            Console.ReadLine();











            /*Console.Write("Give me a date: ");
            string previousDateString = Console.ReadLine();

            Console.Write("what date format do you want to use: ");
            string dateFormat = Console.ReadLine();

            if(dateFormat.Length < 1)
            {
                dateFormat = "M/d/yy";
            }
            
            DateTime previousDate = DateTime.ParseExact(previousDateString, "M/d/yy/", null);
            
            TimeSpan fromPreviousDate = DateTime.Now.Subtract(previousDate);
            
            Console.WriteLine($"IT has been { fromPreviousDate.Days} since {previousDateString}");

            /*Console.Write("Give me a time: ");
            string previousTimeString = Console.ReadLine();

            Console.Write("What time format do you want to use: ");
            string timeFormat = Console.ReadLine();
                
            if (timeFormat.Length < 1)
            {
                timeFormat = "h:m tt";
            }

            DateTime previousTime = DateTime.ParseExact(previousTimeString, timeFormat, null);

            TimeSpan fromPreviousTime = DateTime.Now.Subtract(previousTime);

            if (fromPreviousTime.Ticks < 0)
            {
                fromPreviousTime = fromPreviousTime.Add(TimeSpan.FromHours(24));
            }

            Console.ReadLine();*/
        }
    }
}
