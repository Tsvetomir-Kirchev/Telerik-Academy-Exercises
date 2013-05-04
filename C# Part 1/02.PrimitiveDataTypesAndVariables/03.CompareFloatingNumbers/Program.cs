using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareFloatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompareFloatingPointNumbers(5.00000001, 5.00000003));
            Console.WriteLine(CompareFloatingPointNumbers(5.3, 6.01));
        }

        public static bool CompareFloatingPointNumbers(double number1, double number2)
        {
            bool result;
            if ((float)number1 == (float)number2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
