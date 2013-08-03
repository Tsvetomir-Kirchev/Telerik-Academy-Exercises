using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            SayHelloTo("Tsvetomir");
        }

        public static void SayHelloTo(string to)
        {
            Console.WriteLine("Hello, {0}", to);
        }
    }
}
