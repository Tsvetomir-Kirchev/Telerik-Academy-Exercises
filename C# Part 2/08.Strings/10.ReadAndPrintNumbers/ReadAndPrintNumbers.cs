using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ReadAndPrintNumbers
{
    class ReadAndPrintNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            string decimalOutput = String.Format("{0:D}", number);
            Console.WriteLine("{0,15}", decimalOutput);
            string hexOutput = String.Format("{0:X}", number);
            Console.WriteLine("{0,15}", hexOutput);
            string perOutput = String.Format("{0:P2}", number);
            Console.WriteLine("{0,15}", perOutput);
            string scientOutput = String.Format("{0:#.##e+00}", number);
            Console.WriteLine("{0,15}", scientOutput);
        }
    }
}
