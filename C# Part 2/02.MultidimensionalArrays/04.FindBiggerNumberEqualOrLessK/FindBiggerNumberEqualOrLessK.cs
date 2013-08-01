using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindBiggerNumberEqualOrLessK
{
    class FindBiggerNumberEqualOrLessK
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(array);

            int index = 0;
            while (true)
            {
                index = Array.BinarySearch(array, k);
                if (index < 0)
                {
                    k--;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("The largest number <= k is: {0}", array[index]);
        }
    }
}
