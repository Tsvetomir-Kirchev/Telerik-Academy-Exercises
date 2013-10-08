using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>(2);
            genericList.Add(3);
            genericList.Add(4);
            genericList.Add(5);
            genericList.Add(6);

            Console.WriteLine(genericList.ToString());

            genericList.InsertAt(1, 15);
            Console.WriteLine(genericList.ToString());

            Console.WriteLine("Max: {0}", genericList.Max());
            Console.WriteLine("Min: {0}", genericList.Min());

            genericList.Clear();
            Console.WriteLine(genericList.ToString());
        }
    }
}
