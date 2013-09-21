using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16.PrintDateAndTime
{
    class PrintDateAndTime
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.Write("Enter date and time(day.month.year hour:minute:second): ");
            string inputLine = Console.ReadLine();
            DateTime date = DateTime.Parse(inputLine);
            DateTime outputDate = date.AddHours(6.5);
            Console.WriteLine("Input day and time: {0}", date);
            Console.WriteLine("After 6h 30m: {0}", outputDate);
            Console.WriteLine("Day of week: {0}", outputDate.DayOfWeek);
        }
    }
}
