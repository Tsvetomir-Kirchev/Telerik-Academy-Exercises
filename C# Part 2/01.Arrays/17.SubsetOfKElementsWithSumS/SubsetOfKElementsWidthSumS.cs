using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SubsetOfKElementsWithSumS
{
    class SubsetOfKElementsWidthSumS
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());

            Console.Write("S = ");
            int s = Int32.Parse(Console.ReadLine());

            int[] array = { 1, 2, 3, 4, 5, 6 };

            k = FindSubset(k, s, array);
        }

        private static int FindSubset(int k, int s, int[] array)
        {
            int j = 0;
            int sum = 0;
            List<int> elements = new List<int>();
            for (int i = 0; i < array.Length - k + 1; i++)
            {
                for (j = i; j < k; j++)
                {
                    elements.Add(array[j]);
                    sum += array[j];
                    if (sum == s)
                    {
                        PrintElements(elements);
                        break;
                    }
                    if (sum > s)
                    {
                        break;
                    }
                }
                k++;
                elements.Clear();
                sum = 0;
            }
            return k;
        }

        private static void PrintElements(List<int> elements)
        {
            Console.Write("{");
            for (int i = 0; i < elements.Count; i++)
            {
                if (i == elements.Count - 1)
                {
                    Console.Write("{0}", elements[i]);
                }
                else
                {
                    Console.Write("{0}, ", elements[i]);
                }
            }
            Console.WriteLine("}");
        }
    }
}
