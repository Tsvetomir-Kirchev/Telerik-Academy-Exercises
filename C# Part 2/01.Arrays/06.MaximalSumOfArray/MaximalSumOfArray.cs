using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalSumOfArray
{
    class MaximalSumOfArray
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[k];

            Console.WriteLine("First array: ");
            ReadArrayFromConsole(firstArray);
            Console.WriteLine("Secon array: ");
            ReadArrayFromConsole(secondArray);

            GetMaximalSum(firstArray, secondArray);
        }

        private static void GetMaximalSum(int[] firstArray, int[] secondArray)
        {
            int firstArrSum = GetArrayElementsSum(firstArray);
            int secondArrSum = GetArrayElementsSum(secondArray);

            if (firstArrSum == secondArrSum)
            {
                Console.WriteLine("The sum of the arrays is euqal: {0}", firstArrSum);
            }
            else if (firstArrSum > secondArrSum)
            {
                Console.WriteLine("The sum of first array is bigger: {0}", firstArrSum);
            }
            else
            {
                Console.WriteLine("The sum of second array is bigger: {0}", secondArrSum);
            }
        }

        private static int GetArrayElementsSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        private static void ReadArrayFromConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
