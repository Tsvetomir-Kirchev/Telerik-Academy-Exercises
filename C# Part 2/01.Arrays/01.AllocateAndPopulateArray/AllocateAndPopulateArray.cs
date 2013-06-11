using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AllocateAndPopulateArray
{
    class AllocateAndPopulateArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            InitializeArray(arr);
            PrintArray(arr);
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }

        private static void InitializeArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }
        }
    }
}
