using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CheckNumberForPrime
{
    class CheckNumberForPrime
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());

            bool isPrime = IsPrime(n);
            if (isPrime)
            {
                Console.WriteLine("{0} is prime", n);
            }
            else
            {
                Console.WriteLine("{0} is not prime", n);
            }
        }

        public static bool IsPrime(int n)
        {
            bool prime = true;

            for (int i = 2; i <= n / 2 + 1; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }
    }
}
