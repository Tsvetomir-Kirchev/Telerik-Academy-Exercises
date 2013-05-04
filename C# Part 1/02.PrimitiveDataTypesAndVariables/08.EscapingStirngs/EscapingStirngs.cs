using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EscapingStirngs
{
    class EscapingStirngs
    {
        static void Main(string[] args)
        {
            // Without escaping of the quotes give errors "The use of quoted strings causes difficulties."
            string str = "The \"use\" of quoted strings causes difficulties.";
            Console.WriteLine(str);
        }
    }
}
