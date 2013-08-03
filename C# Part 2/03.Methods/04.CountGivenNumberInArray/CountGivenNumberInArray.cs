using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountGivenNumberInArray
{
    class CountGivenNumberInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 3, 4, 4, 2, 3, 3, 43, 32, 3 };
            int count = GetCount(3, arr);
            Console.WriteLine(count);
        }

        public static int GetCount(int number, int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
