using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CheckThirdNumber
{
    class CheckThirdNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            bool isThirdNumber7 = CheckThirdNumberFor7(number);
            if (isThirdNumber7)
            {
                Console.WriteLine("Third number of {0} is 7", number);
            }
            else
            {
                Console.WriteLine("Third number of {0} is not 7", number);
            }
        }

        public static bool CheckThirdNumberFor7(int number)
        {
            bool result = false;

            int temp = number / 100;
            int thirdNumber = temp % 10;

            if (thirdNumber == 7)
            {
                result = true;
            }

            return result;
        }
    }
}
