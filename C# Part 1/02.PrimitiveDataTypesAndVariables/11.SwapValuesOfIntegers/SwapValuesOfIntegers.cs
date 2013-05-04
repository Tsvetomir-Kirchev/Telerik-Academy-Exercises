using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SwapValuesOfIntegers
{
    class SwapValuesOfIntegers
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before swapping");
            Console.WriteLine("a = {0}, b = {1}", a, b);

            a ^= b;
            b ^= a;
            a ^= b;

            Console.WriteLine("After swapping");
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
