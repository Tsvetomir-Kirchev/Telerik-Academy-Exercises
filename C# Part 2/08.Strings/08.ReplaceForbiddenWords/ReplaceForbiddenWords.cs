using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ReplaceForbiddenWords
{
    class ReplaceForbiddenWords
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords = { "Microsoft", "PHP", "CLR" };
            string text = "Microsoft announced its next generation PHP compiler today. " +
                          "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR." +
                          "PHP is not cool.";

            string censoredText = ReturnCensoredText(text, forbiddenWords);
            Console.WriteLine(censoredText);
        }

        static string ReturnCensoredText(string text, string[] forbiddenWords)
        {
            StringBuilder stars = new StringBuilder();
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                stars.Clear();
                for (int j = 0; j < forbiddenWords[i].Length; j++)
                {
                    stars.Append('*');
                }
                text = text.Replace(forbiddenWords[i], stars.ToString());
            }

            return text;
        }
    }
}
