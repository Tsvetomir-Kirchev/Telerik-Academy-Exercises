using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _15.DistanceBetweenTwoDates
{
    class DistanceBetweenTwoDates
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.Write("Enter the first date (day.month.year): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the second date (day.month.year): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            
            int distance = secondDate.Day - firstDate.Day;

            Console.WriteLine("Distance: {0} days", distance);
        }
    }
}
