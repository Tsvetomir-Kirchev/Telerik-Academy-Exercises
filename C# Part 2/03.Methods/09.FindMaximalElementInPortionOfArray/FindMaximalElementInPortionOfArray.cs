using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FindMaximalElementInPortionOfArray
{
    class FindMaximalElementInPortionOfArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 8, 92, 89, 28, 29, 90, 28 };
            int max = GetMaximalElement(2, arr);
            Console.WriteLine(max); ;
        }

        public static int GetMaximalElement(int startIndex, int[] arr)
        {
            int[] portionArr = new int[arr.Length - startIndex];
            for (int i = startIndex; i < arr.Length; i++)
            {
                portionArr[i - startIndex] = arr[i];
            }

            int[] sortedArr = Sort(portionArr);

            return sortedArr[sortedArr.Length - 1];
        }

        private static int[] Sort(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}
