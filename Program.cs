using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] xs = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            List<int> xs = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < xs.Count -1; ++i)
            {
                xs[i] = xs[i + 1];
            }


        }

        static void Printcollection<b>(List<b> toPrint) => Printcollection(toPrint.ToArray());
        static void Printcollection<a>(a[] toPrint)
        {
            foreach (var x in toPrint)
            {
                Console.WriteLine($"{x}, ");
            }
        }
    }
}
