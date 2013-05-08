using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Number {0} is even", number);
            }
            else
            {
                Console.WriteLine("Number {0} is odd", number);
            }
        }
    }
}
