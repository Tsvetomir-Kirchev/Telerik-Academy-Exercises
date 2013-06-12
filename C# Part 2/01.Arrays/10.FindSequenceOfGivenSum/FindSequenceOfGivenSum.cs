using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSequenceOfGivenSum
{
    class FindSequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            Console.Write("S = ");
            int s = Int32.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            ReadArrayFromConsole(arr);
            FindSequence(arr, s);
        }

        private static void FindSequence(int[] arr, int s)
        {
            int sum = 0;
            List<int> list = new List<int>();
            for (int index = 0; index < arr.Length; index++)
            {
                sum += arr[index];
                list.Add(arr[index]);
                if (sum == s)
                {
                    PrintLsit(list);
                }
                else if (sum > s)
                {
                    sum = arr[index];
                    list.Clear();
                    list.Add(arr[index]);
                }
            }
        }

        private static void PrintLsit(List<int> list)
        {
            Console.Write("{ ");
            foreach (int item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("}");
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
