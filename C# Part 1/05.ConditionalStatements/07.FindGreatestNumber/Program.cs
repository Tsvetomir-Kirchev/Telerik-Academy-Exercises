using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FindGreatestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] variableArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} variable: ", i);
                variableArray[i] = Int32.Parse(Console.ReadLine());
            }

            int biggerNumber = variableArray[0];
            for (int i = 0; i < 4; i++)
            {
                if (variableArray[i] < variableArray[i + 1])
                {
                    biggerNumber = variableArray[i + 1];
                }
            }

            Console.WriteLine(biggerNumber);
        }
    }
}
