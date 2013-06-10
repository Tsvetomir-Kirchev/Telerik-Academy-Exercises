using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintCards
{
    class PrintCards
    {
        static void Main(string[] args)
        {
            string[] cards = {"2", "3", "4", "5", "6", "7",
                                 "8", "9", "10", "J", "Q", "K", "A" };
            string[] paint = { "Spades", "Diamonds", "Hearts", "Clubs" };

            for (int i = 0; i < paint.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Console.WriteLine("{0} - {1}", paint[i], cards[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
