using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CalculateGreatestCommonDevisor
{
    class CalculateGreatestCommonDevisor
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            if ((firstNumber <= 0 || secondNumber <= 0))
            {
                Console.WriteLine("The numbers must be greater than 0!");
            }
            else
            {
                EucleidianAlgorithm(firstNumber, secondNumber);
            }
        }

        public static void EucleidianAlgorithm(int n, int m)
        {
            if (n > m)
            {
                EucleidianAlgorithm((n - m), m);
            }
            else if (n < m)
            {
                EucleidianAlgorithm(n, (m - n));
            }
            else
            {
                Console.WriteLine("The Common Greates Devisor is {0}", n);
                return;
            }
        }
    }
}
