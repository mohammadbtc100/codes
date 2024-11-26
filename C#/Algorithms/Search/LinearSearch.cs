using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public class LinearSearch
    {
        private readonly int[] array;
        private readonly int n;
        public LinearSearch() {
            n = 1;
            this.array = new int[n];
            Console.WriteLine("LinearSearch");
        }
        public LinearSearch(int[] array)
        {
            this.array = array;
            n= array.Length;
            Console.WriteLine("LinearSearch");
        }
        public int find(int x) {
            for (int i = 0; i < n; i++) { 
                if(x==this.array[i]) 
                    return i;
            }
            return -1;
        }
    }
}
