using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.GenerateCombinations
{
    class GenerateCombinations
    {
        private static int numberOfLoops;
        private static int numberOfIterations;
        private static int[] loops;
        private static int counter = 1;

        static void Main()
        {
            Console.Write("N = ");
            numberOfIterations = Int32.Parse(Console.ReadLine());

            Console.Write("K = ");
            numberOfLoops = Int32.Parse(Console.ReadLine());

            loops = new int[numberOfLoops];

            NestedLoops(0);
        }

        private static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }

            for (int i = counter; i <= numberOfIterations; i++)
            {
                if (i == numberOfIterations)
                {
                    counter++;
                }

                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }

        private static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
