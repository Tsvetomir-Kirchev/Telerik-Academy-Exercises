using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare2Arrays
{
    class Compare2Arrays
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] firstArray = new int[n];
            int[] seconArray = new int[n];

            ReadArrayFromConsole(firstArray);
            ReadArrayFromConsole(seconArray);
            bool areEqual = CompareArrays(firstArray, seconArray);

            Console.WriteLine("Are equal: {0}", areEqual);
        }

        private static bool CompareArrays(int[] firstArray, int[] seconArray)
        {
            bool areEqual = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != seconArray[i])
                {
                    areEqual = false;
                }
            }

            return areEqual;
        }

        private static void ReadArrayFromConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }
}
