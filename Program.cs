using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch myTimer = new Stopwatch();

            int[] exampleArray = new int[] { 342, 242, 235, 64, 474, 3, 100, 2 };

            Console.Write("Before sorting: ");
            foreach (int element in exampleArray)
            {
                Console.Write(element + " ");
            }

            myTimer.Start();
            InsertionSort.Sort(exampleArray);
            myTimer.Stop();

            Console.WriteLine();
            Console.Write("After sorting: ");
            foreach (int element in exampleArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\nTime taken: " + myTimer.ElapsedTicks);
        }
    }
}
