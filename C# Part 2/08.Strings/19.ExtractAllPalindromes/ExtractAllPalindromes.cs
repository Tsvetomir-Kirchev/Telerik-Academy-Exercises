using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ExtractAllPalindromes
{
    class ExtractAllPalindromes
    {
        static void Main(string[] args)
        {
            string inputText = "Lorem ipsum dolor sit amet lamal, consectetuer adipiscing ABBA elit,exe sed diam nonummy nibh" +
                " euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci" +
                " tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in " +
                "hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan.";
            StringBuilder word = new StringBuilder();
            List<string> palindromes = new List<string>();
            foreach (char symbol in inputText)
            {
                if (symbol != ' ' && symbol != ',' && symbol != ';' && symbol != ':' && symbol != '.' && symbol != '!' && symbol != '?')
                {
                    word.Append(symbol);
                }
                else
                {
                    if (word.ToString() != String.Empty)
                    {
                        if (IsPalindrom(word.ToString()))
                        {
                            palindromes.Add(word.ToString());
                        }
                    }
                    word.Clear();
                }
            }
            foreach (string palindrom in palindromes)
            {
                Console.WriteLine("    {0}", palindrom);
            }
        }

        static bool IsPalindrom(string inputWord)
        {
            bool result = true;
            for (int i = 0; i < inputWord.Length / 2; i++)
            {
                if (inputWord[i] != inputWord[inputWord.Length - i - 1])
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
