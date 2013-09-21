using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ConvertStringToUnicodeChars
{
    class ConvertStringToUnicodeChars
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            ConvertToUnicode(text);
        }

        static void ConvertToUnicode(string text)
        {
            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                ushort unicode = (ushort)characters[i];
                Console.Write("\\u{0:x4}", unicode);
            }
            Console.WriteLine();
        }
    }
}
