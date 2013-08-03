using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReturnIndex
{
    class ReturnIndex
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2 };
            int index = GetFirstIndexBiggerThanNeightboors(arr);
            Console.WriteLine(index);
        }

        public static int GetFirstIndexBiggerThanNeightboors(int[] arr)
        {
            int index = -1;

            if (arr.Length > 1)
            {
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    {
                        index = i;
                        break;
                    }
                }
            }

            return index;
        }
    }
}
