using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequenceOfEqualElements
{
    class MaximalSequenceOfEqualElements
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
            for (int index = 0; index < arr.Length - 1; index++)
            {
                if (arr[index] == arr[index + 1])
                {
                    counter++;
                    if (counter > maximalSequence)
                    {
                        maximalSequence = counter;
                        lastIndex = index + 1;
                    }
                }
                if ((
                    counter == maximalSequence) && (arr[index] != arr[index + 1]))
                {
                    lastIndex = index;
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
