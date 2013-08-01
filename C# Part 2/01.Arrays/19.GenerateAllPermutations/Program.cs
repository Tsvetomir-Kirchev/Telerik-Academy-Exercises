using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.GenerateAllPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            GeneratePermutations(array, 0, array.Length - 1);
        }

        public static void GeneratePermutations(int[] array, int index, int length)
        {
            if (index == length)
            {
                PrintAllPermutations(length, array);
            }
            else
            {
                for (int i = index; i <= length; i++)
                {
                    Swap(ref array[index], ref array[i]);
                    GeneratePermutations(array, index + 1, length);
                    Swap(ref array[index], ref array[i]);
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            if (a == b)
            {
                return;
            }
            else
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }
        }

        private static void PrintAllPermutations(int length, int[] array)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
