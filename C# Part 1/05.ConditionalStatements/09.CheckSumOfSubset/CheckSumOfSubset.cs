using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CheckSumOfSubset
{
    class CheckSumOfSubset
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter five numbers: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} = ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                if ((arr[i] + arr[i + 1] + arr[i + 2]) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0",
                        arr[i], arr[i + 1], arr[i + 2]);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                if ((arr[i] + arr[i + 1] + arr[i + 2] + arr[i + 3]) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0",
                        arr[i], arr[i + 1], arr[i + 2], arr[i + 3]);
                }
            }
        }
    }
}
