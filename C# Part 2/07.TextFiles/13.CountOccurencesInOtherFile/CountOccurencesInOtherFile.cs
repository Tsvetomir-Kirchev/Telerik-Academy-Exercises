using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CountOccurencesInOtherFile
{
    class CountOccurencesInOtherFile
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            string[] words = GetWordsToCount();

            if (words != null)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (!occurences.ContainsKey(words[i]))
                    {
                        occurences.Add(words[i], 1);
                    }
                }
            }

            string[] allWords = GetAllWords();

            foreach (string word in allWords)
            {
                if (occurences.ContainsKey(word))
                {
                    occurences[word]++;
                }
            }

            foreach (KeyValuePair<string, int> pair in occurences.OrderByDescending(key => key.Value))
            {
                Console.WriteLine("{0}: {1} times.",
                    pair.Key, pair.Value);
            }
        }

        private static string[] GetAllWords()
        {
            string[] allWords = null;
            string path = @"../../text.txt";
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    string allText = reader.ReadToEnd();
                    allWords = allText.Split(' ');
                }
            }
            catch (IOException)
            {
            }

            return allWords;
        }

        private static string[] GetWordsToCount()
        {
            string[] words = null;
            string path = @"../../words.txt";
            try
            {
                StreamReader reader = new StreamReader(path);
                using (reader)
                {
                    string allText = reader.ReadToEnd();
                    words = allText.Split(' ');
                }
            }
            catch (IOException)
            {
            }

            return words;
        }
    }
}
