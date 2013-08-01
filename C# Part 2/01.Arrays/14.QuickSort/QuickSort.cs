using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 56, 2, -5, 32, 12, 90, -87 };
            Console.WriteLine("Unsorted:");
            PrintArray(arr);
            Console.WriteLine("Sorted:");
            Sort(arr);
            PrintArray(arr);
        }

        public static void Sort(int[] items)
        {
            QuickS(items, 0, items.Length - 1);
        }

        private static void QuickS(int[] array, int left, int right)
        {
            int i = left;
            int j = right;

            int x = array[(left + right) / 2];
            do
            {
                while (array[i].CompareTo(x) < 0)
                {
                    i++;
                }
                while (array[j].CompareTo(x) > 0)
                {
                    j--;
                }

                int temp;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            while (i <= j);

            if (left < j)
            {
                QuickS(array, left, j);
            }
            if (i < right)
            {
                QuickS(array, i, right);
            }
        }

        private static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i] + "]");
                }
                else
                {
                    Console.Write(arr[i] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}
