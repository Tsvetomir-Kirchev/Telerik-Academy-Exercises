using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateNNumbers
{
    class CalculateNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            int sum = GetSum(n);
            Console.WriteLine("Sum of the numbers: {0}", sum);
        }

        private static int GetSum(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter number[{0}]: ", i + 1);
                int number = Int32.Parse(Console.ReadLine());
                sum += number;
            }

            return sum;
        }
    }
}
