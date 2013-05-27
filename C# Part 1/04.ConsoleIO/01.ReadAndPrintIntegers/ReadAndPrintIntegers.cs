using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReadAndPrintIntegers
{
    class ReadAndPrintIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers: ");
            int firstNamber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());
            int thirdNumber = Int32.Parse(Console.ReadLine());

            int sum = firstNamber + secondNumber + thirdNumber;
            Console.WriteLine("The sum of the three numbers is {0}", sum);
        }
    }
}
