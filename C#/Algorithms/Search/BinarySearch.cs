using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    internal class BinarySearch
    {
        public BinarySearch() {
            Console.WriteLine("\nDivide and Conquer approach => BinarySearch Algorithm");
        }
        public int NonRecursiveBinarySearch(ref int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (target == array[mid])
                {
                    return mid;
                }
                else if (target < array[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
        public int RecursiveBinarySearch(ref int[] array, int target, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }
            else
            {
                int mid = (low + high) / 2;
                if (target == array[mid])
                {
                    return mid;
                }
                else if (target < array[mid])
                {
                    return RecursiveBinarySearch(ref array, target, low, mid - 1);
                }
                else
                {
                    return RecursiveBinarySearch(ref array, target, mid + 1, high);
                }
            }
        }
    }
}
