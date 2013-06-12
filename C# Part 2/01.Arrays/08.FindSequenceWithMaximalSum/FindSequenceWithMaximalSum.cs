using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FindSequenceWithMaximalSum
{
    class FindSequenceWithMaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            ReadArrayFromConsole(arr);
            FindMaximalSum(arr);
        }

        private static void ReadArrayFromConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        private static void FindMaximalSum(int[] arr)
        {
            int sum = 0;
            int bestSum = Int32.MinValue;
            int counter = 0;
            int firstIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                counter++;
                if (sum < 0)
                {
                    sum = 0;
                    counter = 0;
                }
                else if (sum > bestSum)
                {
                    bestSum = sum;
                    firstIndex = i - counter;
                }
            }

            for (int i = firstIndex + 1; i < counter + firstIndex; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
