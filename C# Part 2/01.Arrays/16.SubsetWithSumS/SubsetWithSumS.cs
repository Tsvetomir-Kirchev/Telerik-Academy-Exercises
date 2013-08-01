using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int s = 14;

            HasSubsetWithSumS(s, arr);
        }

        static void HasSubsetWithSumS(int s, int[] arr)
        {
            Array.Sort(arr);
            List<int> subsetElemets = new List<int>();

            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    subsetElemets.Add(arr[j]);
                    if (sum == s)
                    {
                        PrintSubsetElements(s, subsetElemets);
                        break;
                    }
                    if (sum > s)
                    {
                        sum = 0;
                        subsetElemets.Clear();
                    }
                }
            }
        }

        private static void PrintSubsetElements(int s, List<int> subsetElements)
        {
            Console.Write("yes(");
            for (int i = 0; i < subsetElements.Count; i++)
            {
                if (i == subsetElements.Count - 1)
                {
                    Console.WriteLine("{0})", subsetElements[i]);
                }
                else
                {
                    Console.Write("{0} + ", subsetElements[i]);
                }
            }
        }
    }
}
