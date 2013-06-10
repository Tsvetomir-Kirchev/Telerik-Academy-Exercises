using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NotDivisibleTo3And7
{
    class NotDivisibleTo3And7
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 7 == 0))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
