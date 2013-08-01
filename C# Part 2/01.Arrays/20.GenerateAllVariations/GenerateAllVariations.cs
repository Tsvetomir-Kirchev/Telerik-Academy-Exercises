using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.GenerateAllVariations
{
    class GenerateAllVariations
    {
        private static int numberOfLoops;
        private static int numberOfIterations;
        private static int[] loops;

        static void Main()
        {
            Console.Write("N = ");
            numberOfLoops = Int32.Parse(Console.ReadLine());

            Console.Write("K = ");
            numberOfIterations = Int32.Parse(Console.ReadLine());

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

            for (int i = 1; i <= numberOfIterations; i++)
            {
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
