using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.InternalRepresentationOfFloat
{
    class InternalRepresentationOfFloat
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a float number: ");
            float number = float.Parse(Console.ReadLine());

            bool sign = number < 0;
            if (sign)
            {
                number *= -1;
            }

            GetRepresentation(number, sign);
        }

        public static void GetRepresentation(float number, bool sign)
        {
            int exponent = GetExponent(number);
            bool[] mantissa = GetMantissa(number, exponent);
            Print(sign, exponent, mantissa);
        }

        private static bool[] GetMantissa(float number, int exponent)
        {
            double mantissa = number / Math.Pow(2, exponent);
            bool[] mantissaArr = new bool[23];
            double currentMantissa = 1;
            for (int i = 0; i < mantissaArr.Length; i++)
            {
                if (currentMantissa + Math.Pow(2, (-1) * (i + 1)) <= mantissa)
                {
                    currentMantissa += Math.Pow(2, (-1) * (i + 1));
                    mantissaArr[i] = true;
                }
                else
                {
                    continue;
                }

                if (currentMantissa == mantissa)
                {
                    break;
                }
            }

            return mantissaArr;
        }

        private static int GetExponent(float number)
        {
            int exponent = 0;
            double num = Math.Pow(2, -127);
            for (int i = 0; i < 255; i++)
            {
                num *= 2;
                if (num == number)
                {
                    exponent = i - 127 + 1;
                    break;
                }

                if (num > number && num / 2 < number)
                {
                    exponent = i - 127;
                    break;
                }
            }

            return exponent;
        }

        private static void Print(bool sign, int aExponent, bool[] mantissa)
        {
            Console.WriteLine("Sign: {0}", sign ? "1" : "0");
            Console.Write("Exponent: ");
            sbyte exponent = (sbyte)(aExponent * (-1));
            for (int i = 7; i >= 0; i--)
            {
                if (i == 7)
                {
                    Console.Write(aExponent > 0 ? 1 : 0);
                }
                if (i != 7)
                {
                    Console.Write(((1 << i) & exponent) != 0 ? 0 : 1);
                }
            }
            Console.WriteLine();

            Console.Write("Mantissa: ");
            foreach (var item in mantissa)
            {
                Console.Write(item ? 1 : 0);
            }
            Console.WriteLine();
        }
    }
}
