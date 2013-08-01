using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, -1, 3, 2, -5, 3, 6, 54, 132, 9 };
            Console.WriteLine("Unsorted: ");
            PrintArray(arr);

            Sort(arr, arr.Length);
            Console.WriteLine("Sorted:");
            PrintArray(arr);
        }

        public static void Sort (int[] array, int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = n - 1; j >= i; --j)
                {
                    if (array[j - 1] > array[j])
                    {
                        array[j - 1] ^= array[j];
                        array[j] ^= array[j - 1];
                        array[j - 1] ^= array[j];
                    }
                }
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
