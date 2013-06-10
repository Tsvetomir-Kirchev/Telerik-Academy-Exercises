using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReturnMinAndMaxNumber
{
    class ReturnMinAndMaxNumber
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            int numbersOfSequences = Int32.Parse(Console.ReadLine());

            int number;
            int minValue = Int32.MaxValue;
            int maxValue = Int32.MinValue;

            PrintMinAndMax(numbersOfSequences, ref minValue, ref maxValue);
        }

        private static void PrintMinAndMax(int numbersOfSequences, ref int minValue, ref int maxValue)
        {
            int number;
            for (int i = 0; i < numbersOfSequences; i++)
            {
                Console.Write("Enter a number: ");
                number = Int32.Parse(Console.ReadLine());
                if (number > maxValue)
                {
                    maxValue = number;
                }
                else if (number < minValue)
                {
                    minValue = number;
                }
            }

            Console.WriteLine("Max number is: {0}", maxValue);
            Console.WriteLine("Min number is: {0}", minValue);
        }
    }
}
