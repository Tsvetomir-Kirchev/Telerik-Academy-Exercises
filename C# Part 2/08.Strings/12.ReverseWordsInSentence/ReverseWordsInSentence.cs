using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ReverseWordsInSentence
{
    class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";

            string reversedWords = ReverseWords(sentence);
            Console.WriteLine(reversedWords);
        }

        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            int index = words.Length;
            string[] reversedWords = new string[index];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < index; i++)
            {
                reversedWords[index - i - 1] = words[i];
                sb.Append(words[index - i - 1]);
                if (i != (index - 1))
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
