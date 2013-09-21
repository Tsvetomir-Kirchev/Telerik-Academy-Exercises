using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SimpleDictionary
{
    class SimpleDictionary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to explain <.NET, CLR, namespace>: ");
            string word = Console.ReadLine();
            string explanation = GetExplanation(word);
            Console.WriteLine("{0} - {1}", word, explanation);
        }

        static string GetExplanation(string word)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            const int WORDS_COUNT = 3;

            string[] tKeys = new string[WORDS_COUNT] { ".NET", "CLR", "namespace" };
            string[] tValues = new string[WORDS_COUNT]
            {
                "platform for applications from Microsoft",
                "managed execution environment for .NET",
                "hierarchical organization of classes",
            };
            for (int i = 0; i < WORDS_COUNT; i++)
            {
                dictionary.Add(tKeys[i].ToUpper(), tValues[i]);
            }

            return dictionary[word.ToUpper()];
        }
    }
}
