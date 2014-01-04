using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SubstringForStringBuilder
{
    class SubstringFirStringBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, how are you?");
            Console.WriteLine(sb.Substring(7, 10));
        }
    }
}
