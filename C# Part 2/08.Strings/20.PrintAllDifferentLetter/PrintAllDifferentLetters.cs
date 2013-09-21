using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.PrintAllDifferentLetter
{
    class PrintAllDifferentLetters
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            int[] arr = new int[26];
            foreach (var item in str)
            {
                char tempChar = Char.ToUpper(item);
                if (tempChar >= 'A' && tempChar <= 'Z')
                {
                    int index = (int)(tempChar - 'A');
                    arr[index]++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    char tempChar = (char)(i + 'A');
                    Console.WriteLine("Letter {0} appears {1} time(s)", tempChar, arr[i]);
                }
            }
        }
    }
}
