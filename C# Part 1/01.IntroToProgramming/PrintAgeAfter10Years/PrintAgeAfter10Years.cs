using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAgeAfter10Years
{
    class PrintAgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.Write("Age = ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Age after 10 years: {0}", age + 10);
        }
    }
}
