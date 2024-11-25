using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DP
{
    public class Fibonacci
    {
        public Fibonacci() {
            Console.WriteLine("\nDynamic Programming Approach => Fibonacci Algorithm O(n)");
        }
        public int RecFibo(int n)
        {
            //A suboptimal method with Repetitive sentences
            if (n <=1) return n;
            else return RecFibo(n-2)+RecFibo(n-1);
        }
        public int fibo(int n)
        {
            //A Dynamic Approach
            int[] array = new int[n];
            array[0] = 0;
            if (n > 0)
            {
                array[1] = 1;
                for(int i=2; i<n; i++)
                {
                    array[i] = array[i-1] + array[i-2];
                }
            }
            return array[n-1];
        }
    }
}
