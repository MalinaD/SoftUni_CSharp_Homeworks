using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Beer Time
//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in 
//format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//and prints “beer time” or “non-beer time” according to the definition above or “invalid time” 
//if the time cannot be parsed. Note that you may need to learn how to parse dates and times. Examples:
//time	result
//1:00 PM	beer time
//4:30 PM	beer time
//10:57 PM	beer time
//8:30 AM	non-beer time
//02:59 AM	beer time
//03:00 AM	non-beer time
//03:26 AM	non-beer time


namespace _10BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo enUS = new CultureInfo("en-US");

            Console.WriteLine("Please enter time");
            string firstTime = Console.ReadLine();
            DateTime time = DateTime.Parse(firstTime);
            string timeToday = time.ToString("hh:mm tt");

            if (DateTime.TryParseExact(timeToday, "hh:mm tt", enUS, DateTimeStyles.None, out time))
            {

                DateTime startTime = DateTime.Parse("1:00 PM");
                DateTime endTime = DateTime.Parse("3:00 AM");

                Console.WriteLine();
                Console.WriteLine("The time you entered is " + timeToday);

                if (time >= startTime || time <= endTime)
                {
                    Console.WriteLine("It is beer time");
                }
                else Console.WriteLine("It is not beer time");
            }
            else Console.WriteLine("Invalid time");
            Console.ReadLine();
        }
    }
}
