using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SubstringCounter
{
    class SubstringCounter
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. " + 
                "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string target = "in";

            int count = CountOccurences(text, target);
            Console.WriteLine("{0} occures {1} times.",
                target, count);
        }

        public static int CountOccurences(string text, string target)
        {
            int count = 0;
            int index = -1;
            while (true)
            {
                index++;
                index = text.ToUpper().IndexOf(target.ToUpper(), index);
                if (index == -1)
                {
                    break;
                }
                count++;
            }

            return count;
        }
    }
}
