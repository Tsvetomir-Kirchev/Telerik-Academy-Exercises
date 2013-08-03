using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CheckTwoNeightboorsInArray
{
    class CheckTwoNeighboorsInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 2, 3, 2, 7 };
            bool isBigger = IsBiggerThanNeighboors(6, arr);
            Console.WriteLine(isBigger);
        }

        public static bool IsBiggerThanNeighboors(int index, int[] arr)
        {
            bool isBigger = false;

            if(index != 0 && index != arr.Length - 1)
            {
                if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
                {
                    isBigger = true;
                }
            }
            else if (index == 0 && index != arr.Length - 1)
            {
                if (arr[index] > arr[index + 1])
                {
                    isBigger = true;
                }
            }
            else if(index != 0 && index == arr.Length - 1)
            {
                if(arr[index] > arr[index - 1])
                {
                    isBigger = true;
                }
            }

            return isBigger;
        }
    }
}
