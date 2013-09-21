using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.ReplaceIdenticalLetters
{
    class ReplaceIdenticalLetters
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            bool newLetter = true;
            letters.Append(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    newLetter = false;
                }
                else
                {
                    newLetter = true;
                }
                if (newLetter)
                {
                    letters.Append(str[i]);
                }
            }
            Console.WriteLine(letters.ToString());
        }
    }
}
