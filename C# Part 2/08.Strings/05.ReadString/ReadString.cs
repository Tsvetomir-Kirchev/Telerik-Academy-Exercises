using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReadString
{
    class ReadString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string with maximum 20 characters: ");
            string text = Console.ReadLine();

            string str = FillStringWithStar(text);
            Console.WriteLine(str);
        }

        public static string FillStringWithStar(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 20)
                {
                    sb.Append('*');
                }
                else
                {
                    sb.Append(text[i]);
                }
            }

            return sb.ToString();
        }
    }
}
