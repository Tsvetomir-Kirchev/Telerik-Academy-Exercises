using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EncodeDecodeStrings
{
    class EncodeDecodeStrings
    {
        static void Main(string[] args)
        {
            string cipher = "abc";
            string text = "Some string";

            string encode = EncodeDecode(text, cipher);
            Console.WriteLine("Encoded: {0}", encode);
            string decode = EncodeDecode(encode, cipher);
            Console.WriteLine("Decoded: {0}", decode);
        }

        static string EncodeDecode(string text, string cipher)
        {
            Queue<char> cipherQueue = new Queue<char>(cipher);
            StringBuilder output = new StringBuilder();

            char code;
            foreach (char item in text)
            {
                code = cipherQueue.Dequeue();
                cipherQueue.Enqueue(code);
                output.Append((char)(item ^ code));
            }
            return output.ToString();
        }
    }
}
