using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09.CalculateCatalanNumbers
{
    class CalculateCatalanNumbers
    {
        static void Main(string[] args)
        {
            BigInteger catalan = 1;
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int lengt = 2 * n;
            int[] p = new int[lengt];
            int[] q = new int[lengt];

            for (int i = 2; i <= n; i++)
            {
                MakeInPrimes(i, q);
            }

            for (int i = n + 2; i <= 2 * n; i++)
            {
                MakeInPrimes(i, p);
            }

            for (int i = 0; i < lengt; i++)
            {
                for (int j = p[i] - q[i]; j > 0; j--)
                {
                    catalan *= i;
                }
            }
            Console.WriteLine(catalan);
        }

        private static void MakeInPrimes(int num, int[] q)
        {
            bool isPrime = true;
            int divider = 2;
            int checkNumber = num;
            int maxDivider = (int)Math.Sqrt(num);
            while (divider <= maxDivider)
            {
                if (checkNumber % divider == 0)
                {
                    q[divider]++;
                    checkNumber = checkNumber / divider;
                    divider--;
                }
                divider++;
            }
            if (isPrime)
            {
                q[checkNumber]++;
            }
        }
    }
}
