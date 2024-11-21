using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public class LinearSearch<T>
    {
        private readonly T[] items;
        private readonly int n;
        public LinearSearch() {
            n = 1;
            this.items = new T[n];
            Console.WriteLine("LinearSearch");
        }
        public LinearSearch(T[] items){
            this.items = items;
            n=items.Length;
            Console.WriteLine("LinearSearch");
        }
        public int find(T item) {
            for (int i = 0; i < n; i++) { 
                if(item.Equals(this.items[i])) 
                    return i;
            }
            return -1;
        }
    }
}
