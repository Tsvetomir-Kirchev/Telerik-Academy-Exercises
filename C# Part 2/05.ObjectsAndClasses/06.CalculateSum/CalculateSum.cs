using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateSum
{
    class CalculateSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers saparated by space: ");
            string numberString = Console.ReadLine();

            int sum = CalculateSumFromString(numberString);
            Console.WriteLine("The sum of the nbumbers is: {0}", sum);
        }

        public static int CalculateSumFromString(string stringNumber)
        {
            string[] numbers = stringNumber.Split(' ');

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += (Int32.Parse(numbers[i]));
            }

            return sum;
        }
    }
}
