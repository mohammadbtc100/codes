using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    internal class BubbleSort
    {
        public BubbleSort() {
            Console.WriteLine("BubbleSort");
        }
        public void sort(ref int[] items) {
            int n=items.Length;
            int t;
            for (int i = 0; i < n; i++) {
                for (int j = i+1; j < n; j++) {
                    if (items[i] > items[j])
                     {
                        t = items[i];
                        items[i] = items[j];
                        items[j] = t;
                    }
                }
            }
        }
    }
}
