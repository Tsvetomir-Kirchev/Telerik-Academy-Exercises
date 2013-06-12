using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            ReadArrayFromConsole(arr);
            Array.Sort(arr);
            FindMostFrequentNumber(arr);
        }

        private static void FindMostFrequentNumber(int[] arr)
        {
            int counter = 1;
            int mostFrequentNumber = 0;
            int frequencyCount = Int32.MinValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (frequencyCount < counter)
                    {
                        mostFrequentNumber = arr[i];
                        frequencyCount = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine("The most frequent number is: {0} with {1} times containing.",
                mostFrequentNumber, frequencyCount);
        }

        private static void ReadArrayFromConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
