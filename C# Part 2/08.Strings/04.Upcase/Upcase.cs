using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Upcase
{
    class Upcase
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. " +
                "We don't have <upcase>anything</upcase> else.";
            string upText = UpCaseFromTags(text);

            Console.WriteLine(upText);
        }

        public static string UpCaseFromTags(string text)
        {
            string openTag = "<upcase>";
            string closeTag = ("</upcase>");

            int range = 0;
            int firstIndex = 0;
            int lastIndex = 0;
            string buffer1 = string.Empty;
            string buffer2 = string.Empty;
            while (true)
            {
                firstIndex = text.IndexOf(openTag, lastIndex);
                lastIndex = text.IndexOf(closeTag, lastIndex + 1);
                range = lastIndex - firstIndex;
                buffer1 = text.Substring(firstIndex, range + closeTag.Length);
                buffer2 = text.Substring(firstIndex + openTag.Length, range - closeTag.Length + 1);
                buffer2 = buffer2.ToUpper();

                text = text.Replace(buffer1, buffer2);

                if (lastIndex > text.Length - 1)
                {
                    break;
                }
            }

            return text;
        }
    }
}
