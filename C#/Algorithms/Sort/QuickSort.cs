using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class QuickSort
    {
        public QuickSort() {
            Console.WriteLine("QuickSort");
        }
        public void sort(ref int[] array, int low, int high)
        {
            var i = low;
            var j = high;
            var pivot = array[low];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (low < j)
                sort(ref array, low, j);

            if (i < high)
                sort(ref array, i, high);

        }
    }
}
