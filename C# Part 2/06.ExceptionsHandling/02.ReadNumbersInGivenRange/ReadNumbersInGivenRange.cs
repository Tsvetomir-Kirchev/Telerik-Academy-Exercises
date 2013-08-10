using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadNumbersInGivenRange
{
    class ReadNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            int number = 0;
            int start = 0;
            int end = 100;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    number = ReadNumber(start, end);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number must be between {0} and {1}",
                    start, end);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Provided parameters are not correct.");
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a number.");
            }
        }

        public static int ReadNumber(int start, int end)
        {
            if (start == end || start > end)
            {
                throw new ArgumentException();
            }

            int number = Int32.Parse(Console.ReadLine());
            if(number < start || number > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
    }
}
