using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExtractSentenceWithGivenWord
{
    class ExtractSentenceWithGivenWord
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. " +
                "We don't have anything else. Inside the submarine is very tight! " +
                "So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";

            ExtractSentences(text, word);
        }

        static void ExtractSentences(string text, string word)
        {
            List<string> list = new List<string>();
            string[] sentences = text.Split('.', '!', '?');

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(' ');
                foreach (var item in words)
                {
                    if (item.Equals(word))
                    {
                        list.Add(sentences[i]);
                    }
                }
            }

            Console.WriteLine("Sentences with {0} in them: ", word);
            foreach (var item in list)
            {
                Console.WriteLine(item.Trim() + ".");
            }
        }
    }
}
