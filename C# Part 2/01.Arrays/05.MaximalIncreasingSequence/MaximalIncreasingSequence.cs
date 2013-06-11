using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int arrLength = Int32.Parse(Console.ReadLine());
            int[] arr = new int[arrLength];
            ReadArrayFromConsole(arr);

            FindMaximalSequence(arr);
        }

        private static void FindMaximalSequence(int[] arr)
        {
            int maximalSequence = 0;
            int firstIndex = 0;
            int lastIndex = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == (arr[i + 1] - 1))
                {
                    counter++;
                    if (counter > maximalSequence)
                    {
                        maximalSequence = counter;
                        lastIndex = i + 1;
                    }
                }
                if ((counter == maximalSequence) && (arr[i] != (arr[i + 1] - 1)))
                {
                    lastIndex = i;
                    counter = 0;
                }
            }

            firstIndex = lastIndex - maximalSequence;

            PrintMaxSequence(firstIndex, lastIndex, arr);
        }

        private static void PrintMaxSequence(int firstIndex, int lastIndex, int[] arr)
        {
            Console.Write("{");
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                if (i < lastIndex)
                {
                    Console.Write("{0},", arr[i]);
                }
                else
                {
                    Console.Write("{0}", arr[i]);
                }
            }
            Console.WriteLine("}");
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
