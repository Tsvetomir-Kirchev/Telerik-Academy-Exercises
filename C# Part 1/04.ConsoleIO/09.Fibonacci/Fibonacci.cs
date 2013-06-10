using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            PrintFirst100FibonacciSequence();
        }

        private static void PrintFirst100FibonacciSequence()
        {
            decimal previous = 0;
            decimal result = 1;
            decimal sum = 0;

            for (int i = 0; i < 100; i++)
            {
                sum = result + previous;
                previous = result;
                result = sum;
                Console.WriteLine(result);
            }
        }
    }
}
