using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    // This class will use the insertion sort algorithm to sort
    // an integer array in ascending order
    public class InsertionSort
    {
        private static bool More(int value1, int value2)
        {
            return value1 > value2;     // returns true if value1 is more than value2
        }

        public static void Sort(int[] arr)
        {
            int size = arr.Length;

            int i, j, temp;

            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < size - 1; j++)
                {
                    while (More(arr[j], arr[j + 1]))
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

    }
}
