using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ReadAndPrintNNumbers
{
    class ReadAndPrintNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            ReadAndPrintNumbers(n);
        }

        private static void ReadAndPrintNumbers(int n)
        {
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter number[{0}]: ", i + 1);
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            ReadAndPrintNumbers(numbers);
        }

        private static void ReadAndPrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
