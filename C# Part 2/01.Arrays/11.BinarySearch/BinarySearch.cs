using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Element (between 0 and 1000) = ");
            int element = Int32.Parse(Console.ReadLine());

            int[] sortedArray = new int[1000];
            for (int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] = i;
            }

            int elementIndex = GetIndex(sortedArray, element, sortedArray[0], sortedArray.Length);
            Console.WriteLine("The index of {0} is: {1}",
                element, elementIndex);
        }

        private static int GetIndex(int[] arr, int element, int min, int max)
        {
            if (max < min)
            {
                return -1;
            }
            int middle = (min + max) / 2;

            if (arr[middle] > element)
            {
                return GetIndex(arr, element, min, middle - 1);
            }
            else if (arr[middle] < element)
            {
                return GetIndex(arr, element, middle + 1, max);
            }
            else
            {
                return middle;
            }
        }
    }
}
