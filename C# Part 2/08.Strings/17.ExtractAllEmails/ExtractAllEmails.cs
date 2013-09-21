using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ExtractAllEmails
{
    class ExtractAllEmails
    {
        static void Main(string[] args)
        {
            string inputText = "some@mail.com add some poeple in the group of c# ninjas. email@asd.com and another@mail.com ";
            StringBuilder word = new StringBuilder();
            List<string> eMails = new List<string>();
            foreach (char symbol in inputText)
            {
                if (symbol != ' ' && symbol != ',' && symbol != ';' && symbol != ':' && symbol != '.' && symbol != '!' && symbol != '?')
                {
                    word.Append(symbol);
                }
                else if (symbol == '.')
                {
                    if (CheckForAT(word.ToString()))
                    {
                        word.Append(symbol);
                    }
                    else
                    {
                        if (word.ToString() != String.Empty)
                        {
                            if (IsThisEmail(word.ToString()))
                            {
                                eMails.Add(word.ToString());
                            }
                        }
                        word.Clear();
                    }
                }
                else
                {
                    if (word.ToString() != String.Empty)
                    {
                        if (IsThisEmail(word.ToString()))
                        {
                            eMails.Add(word.ToString());
                        }
                    }
                    word.Clear();
                }
            }
            Console.WriteLine("Extracted emails are: ");
            Console.WriteLine();
            for (int index = 0; index < eMails.Count; index++)
            {
                eMails[index] = eMails[index].Trim(' ', '.');
                Console.WriteLine("{0}:   {1}", index + 1, eMails[index]);
            }
            Console.WriteLine();
        }

        static bool CheckForAT(string currentWord)
        {
            string workValue = currentWord;
            int indexOfAT = currentWord.IndexOf("@");
            if (indexOfAT < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool IsThisEmail(string currentWord)
        {
            currentWord = currentWord.Trim('.');
            int indexOfAT = currentWord.IndexOf("@");
            int indexOfPoint = 0;
            if (indexOfAT > 0)
            {
                indexOfPoint = currentWord.IndexOf('.', indexOfAT);
                if (indexOfPoint > indexOfAT)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
