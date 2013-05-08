using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.IsBit1
{
    class IsBit1
    {
        static void Main(string[] args)
        {
            Console.Write("number = ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = Int32.Parse(Console.ReadLine());

            bool isBit1 = Is1(number, p);
            Console.WriteLine(isBit1);
        }

        public static bool Is1(int number, int p)
        {
            bool result = false;

            int mask = 1 << p;
            int temp = number & mask;
            if (temp != 0)
            {
                result = true;
            }

            return result;
        }
    }
}
