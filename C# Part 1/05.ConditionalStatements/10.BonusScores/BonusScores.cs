using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            Console.Write("scores = ");
            int scores = Int32.Parse(Console.ReadLine());

            CalculateBonus(scores);
        }

        private static void CalculateBonus(int scores)
        {
            switch (scores)
            {
                case 1:
                    scores *= 10;
                    break;
                case 2:
                    scores *= 10;
                    break;
                case 3:
                    scores *= 10;
                    break;
                case 4:
                    scores *= 100;
                    break;
                case 5:
                    scores *= 100;
                    break;
                case 6:
                    scores *= 100;
                    break;
                case 7:
                    scores *= 1000;
                    break;
                case 8:
                    scores *= 1000;
                    break;
                case 9:
                    scores *= 1000;
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            Console.WriteLine("Scores with bonus: {0}", scores);
        }
    }
}
