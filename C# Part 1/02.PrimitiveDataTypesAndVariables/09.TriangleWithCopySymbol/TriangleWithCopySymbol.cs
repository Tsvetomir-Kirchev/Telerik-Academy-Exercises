using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TriangleWithCopySymbol
{
    class TriangleWithCopySymbol
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char copy = '\u00A9';
            Console.WriteLine("   {0}", copy);
            Console.WriteLine("  {0} {0}", copy);
            Console.WriteLine(" {0}   {0}", copy);
            Console.WriteLine("{0} {0} {0} {0}", copy);
        }
    }
}
