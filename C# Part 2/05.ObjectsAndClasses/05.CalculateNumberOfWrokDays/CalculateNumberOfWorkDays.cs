using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateNumberOfWrokDays
{
    class CalculateNumberOfWorkDays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a date in yyyy/mm/dd format: ");
            DateTime date = new DateTime();
            try
            {
                date = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format!");
            }

            int workDays = CalculateWorkDays(date, DateTime.Now);
            Console.WriteLine("Work days between {0} and {1} are {2}",
                date, DateTime.Now, workDays);
        }

        public static int CalculateWorkDays(DateTime startDate, DateTime endDate)
        {
            DateTime sdt = startDate.Subtract(startDate.TimeOfDay);
            DateTime edt = endDate.Subtract(endDate.TimeOfDay);

            if (sdt > edt)
            {
                return 0;
            }

            int workDays = (int)edt.Subtract(sdt).TotalDays + 1;
            int weeks = workDays / 7;


            workDays -= weeks * 2;

            edt = edt.AddDays(-weeks * 7);

            if (edt > sdt)
            {
                if (sdt.DayOfWeek > edt.DayOfWeek &&
                    edt.DayOfWeek < DayOfWeek.Saturday && edt.DayOfWeek > DayOfWeek.Sunday)
                {
                    workDays -= 2;
                }
                else
                {
                    if (sdt.DayOfWeek == DayOfWeek.Saturday || sdt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        workDays--;
                    }

                    if (edt.DayOfWeek == DayOfWeek.Saturday || edt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        workDays--;
                    }
                }
            }

            return workDays;
        }
    }
}
