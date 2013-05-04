using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MostAppropriateDataTypes
{
    class MostAppropriateDataTypes
    {
        static void Main(string[] args)
        {
            ushort ush = 52130;
            sbyte sb = -115;
            int i = 4825932;
            byte b = 97;
            short sh = -10000;

            Console.WriteLine("ushort: {0}", ush);
            Console.WriteLine("sbyte: {0}", sh);
            Console.WriteLine("int: {0}", i);
            Console.WriteLine("byte: {0}", b);
            Console.WriteLine("short: {0}", sh);
        }
    }
}
