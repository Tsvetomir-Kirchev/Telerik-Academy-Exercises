using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Casting
{
    class Casting
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object obj = hello + " " + world;
            string helloWorld = (string)obj;
            Console.WriteLine(helloWorld);
        }
    }
}
