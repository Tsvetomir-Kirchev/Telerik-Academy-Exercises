using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetBiggerNumber
{
    class GetBiggerNumber
    {
        static void Main(string[] args)
        {
            int max = GetMax(5, GetMax(4, 7));
            Console.WriteLine(max);
        }

        public static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
