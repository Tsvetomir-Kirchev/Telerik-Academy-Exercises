using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CalculateMethodsWithGenerics
{
    class CalculateMethodsWithGenerics
    {
        static void Main(string[] args)
        {
            GetMinimumValue(23.321, 3.1, 123);
            GetMaximumValue(123.321, 43.32, 121);
            CalculateAverage(2, 3, 2);
            CalculateSum(4, 6);
            CalculateProduc(2.4, 2.1, 2.0);
        }

        public static void GetMinimumValue<T>(params T[] numbers) where T : IComparable<T>
        {
            dynamic minValue = numbers[0];

            foreach (var item in numbers)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }
            Console.WriteLine("Min value is: {0}", minValue);
        }

        public static void GetMaximumValue<T>(params T[] numbers) where T : IComparable<T>
        {
            T max = default(T);

            foreach (var item in numbers)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            Console.WriteLine("Max value: {0}", max);
        }

        public static void CalculateAverage<T>(params T[] numbers)
        {
            dynamic sum = default(T);

            foreach (var elem in numbers)
            {
                sum += elem;
            }
            dynamic average = sum / numbers.Length;
            Console.WriteLine("Average: {0}", average);
        }

        public static void CalculateSum<T>(params T[] numers)
        {
            dynamic sum = default(T);

            foreach (var elem in numers)
            {
                sum += elem;
            }
            Console.WriteLine("Sum: {0}", sum);
        }

        public static void CalculateProduc<T>(params T[] numbers)
        {
            dynamic product = (object)1;

            foreach (var item in numbers)
            {
                product *= item;
            }
            Console.WriteLine("Product: {0}", product);
        }
    }
}
