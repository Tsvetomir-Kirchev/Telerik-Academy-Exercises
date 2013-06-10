using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateNKFactorial
{
    class CalculateNKFactorial
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;
            for (int i = n; i > 0; i--)
            {
                nFactorial *= i;
            }

            BigInteger kFactorial = 1;
            for (int i = k; i > 0; i--)
            {
                kFactorial++;
            }

            BigInteger nKFactorial = 1;
            for (int i = (k - n); i > 0; i--)
            {
                nKFactorial *= i;
            }

            BigInteger result = (nFactorial * kFactorial) / nKFactorial;
            Console.WriteLine(result);
        }
    }
}
