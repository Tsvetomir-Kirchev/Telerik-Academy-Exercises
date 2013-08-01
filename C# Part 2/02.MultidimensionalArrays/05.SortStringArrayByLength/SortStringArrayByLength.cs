using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortStringArrayByLength
{
    class SortStringArrayByLength
    {
        static void Main(string[] args)
        {
            string[] array = { "hi", "hello", "some", "text", "a", "interesting", "b" };

            Sort(array);
        }

        static void Sort(string[] array)
        {
            var arrayAnscending =
                from arr in array
                orderby arr.Length
                select arr;

            foreach (var arr in arrayAnscending)
            {
                Console.WriteLine(arr);
            }
        }
    }
}
