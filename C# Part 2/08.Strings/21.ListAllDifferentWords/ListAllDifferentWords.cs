using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.ListAllDifferentWords
{
    class ListAllDifferentWords
    {
        static void Main(string[] args)
        {
            string str = "Some not so interesting text. Just for the example, just to do some work";
            StringBuilder word = new StringBuilder();
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (char symbol in str)
            {
                if (symbol != ' ' && symbol != ',' && symbol != ';'
                    && symbol != ':' && symbol != '.' && symbol != '!' && symbol != '?')
                {
                    word.Append(symbol);
                }
                else
                {
                    if (word.ToString() != String.Empty)
                    {
                        string temp = word.ToString().ToUpper();
                        if (DoWordExist(temp, words))
                        {
                            words[temp]++;
                        }
                        else
                        {
                            words.Add(temp, 1);
                        }
                    }
                    word.Clear();
                }
            }
            foreach (KeyValuePair<string, int> pair in words)
            {
                Console.WriteLine("Word {0} appears {1} time(s).", pair.Key, words[pair.Key]);
            }
        }

        static bool DoWordExist(string currentWord, Dictionary<string, int> dictionary)
        {
            int value;
            if (dictionary.TryGetValue(currentWord, out value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
