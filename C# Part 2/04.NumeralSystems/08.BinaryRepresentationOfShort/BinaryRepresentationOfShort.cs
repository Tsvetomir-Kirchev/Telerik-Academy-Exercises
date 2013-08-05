using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BinaryRepresentationOfShort
{
    class BinaryRepresentationOfShort
    {
        static void Main(string[] args)
        {
            Console.Write("Write a short number: ");
            short number = Int16.Parse(Console.ReadLine());

            BinaryRepresentation(number);
        }

        public static void BinaryRepresentation(int number)
        {
            List<int> binary = new List<int>();
            int sign = number;
            int count = 0;
            while (number != 0)
            {
                binary.Add(Math.Abs(number % 2));
                number /= 2;
                count++;
            }
            if (sign >= 0)
            {
                while (count < 16)
                {
                    binary.Add(0);
                    count++;
                }
            }
            else
            {
                while (count < 16)
                {
                    binary.Add(1);
                    count++;
                }
            }
            binary.Reverse();
            int space = 0;
            foreach (var item in binary)
            {
                Console.Write(item);
                space++;
                if (space % 4 == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
