using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CheckYearForLeap
{
    class CheckYearForLeap
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an year: ");
            int year = Int32.Parse(Console.ReadLine());

            bool isLeap = DateTime.IsLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("{0} year is leap.", year);
            }
            else
            {
                Console.WriteLine("{0} year is not leap.", year);
            }
        }
    }
}
