using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SequenceOfFibonacci
{
    class SequenceOfFibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            decimal previous = 0;
            decimal next = 1;
            decimal fibonacci = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", fibonacci);
                previous = next;
                next = fibonacci;
                fibonacci = previous + next;
            }
            Console.WriteLine();
        }
    }
}
