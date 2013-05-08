using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CanDevideTo5And7
{
    class CanDevideTo5And7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("Number: {0} is devide by 5 and 7 without reminder", number);
            }
            else
            {
                Console.WriteLine("Number: {0} do not devide by 5 and 7 without reminder", number);
            }
        }
    }
}
