using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class MergeSort
    {
        public MergeSort() {
            Console.WriteLine("MergeSort");
        }
        public void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }
        public int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);

                MergeArray(array, left, middle, right);
            }

            return array;
        }
    }
}
