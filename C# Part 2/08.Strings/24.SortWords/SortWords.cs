using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.SortWords
{
    class SortWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some words: ");
            string str = Console.ReadLine();
            char[] wordSeparator = new char[] { ' ', ',', ';', ':' };
            string[] words = str.Split(wordSeparator, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                int bestPos = i;
                for (int j = i; j < words.Length; j++)
                {
                    if (words[bestPos].CompareTo(words[j]) > 0)
                    {
                        bestPos = j;
                    }
                }
                string tempStr = words[bestPos];
                words[bestPos] = words[i];
                words[i] = tempStr;
            }
            Console.WriteLine("Sorted words: ");
            foreach (string word in words)
            {
                Console.WriteLine("{0}", word);
            }
        }
    }
}
