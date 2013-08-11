using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string sample = "sample";
            for (int i = sample.Length - 1; i >= 0; i--)
            {
                Console.Write(sample[i]);
            }
            Console.WriteLine();
        }
    }
}
