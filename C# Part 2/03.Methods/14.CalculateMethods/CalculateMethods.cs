using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CalculateMethods
{
    class CalculateMethods
    {
        static void Main(string[] args)
        {
            GetMinimumValue(2, 3, 1, 4);
            GetMaximumValue(21, 3, 1);
            CalculateAverage(12, 321, 123, 431, 643, 132);
            CalculateSum(12, 32, 35, 65, 78);
            CalculateProduct(2, 2, 2);
        }

        public static void GetMinimumValue(params int[] numbers)
        {
            int minValue = Int32.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (minValue > numbers[i])
                {
                    minValue = numbers[i];
                }
            }
            Console.WriteLine("Min value: {0}", minValue);
        }

        public static void GetMaximumValue(params int[] numbers)
        {
            int maxValue = Int32.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxValue < numbers[i])
                {
                    maxValue = numbers[i];
                }
            }
            Console.WriteLine("Max value: {0}", maxValue);
        }

        public static void CalculateAverage(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            int average = sum / numbers.Length;
            Console.WriteLine("The average is: {0}", average);
        }

        public static void CalculateSum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("The sum is: {0}", sum);
        }

        public static void CalculateProduct(params int[] numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine("The product is: {0}", product);
        }
    }
}
