using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.QuickSortOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = 
            {
                "hello", "hi", "C", 
                "B", "a", "help", "cool"
            };
            Console.WriteLine("Unsorted:");
            PrintArray(arr);

            Sort(arr);
            Console.WriteLine("Sorted:");
            PrintArray(arr);
        }

        public static void Sort(string[] items)
        {
            QuickSort(items, 0, items.Length - 1);
        }

        public static void QuickSort(string[] array, int left, int right)
        {
            int i = left;
            int j = right;

            string x = array[(left + right) / 2];
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

                string temp;
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
                QuickSort(array, left, j);
            }
            if (i < right)
            {
                QuickSort(array, i, right);
            }
        }

        private static void PrintArray(string[] arr)
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
