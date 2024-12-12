using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms.Generics;
using Algorithms.Search;
using Algorithms.Sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mohammad Ahmadzadeh, Skill National University of Minab
            //تعریف یک آرایه عددی
            int[] numbers = DbContext.numbers;
            //طول آرایه
            int n = numbers.Length;
            //چاپ آرایه
            Terminal.printArray("Array : ",numbers);

            /*BubbleSort b = new BubbleSort();
            b.sort(ref numbers);
            Terminal.printArray("BubbleSort",numbers);*/

            /*var sort = new MergeSort();
            sort.mergeSort(numbers, 0, n - 1);
            Terminal.printArray("MergeSort", numbers);*/


            QuickSort qSort = new QuickSort();
            qSort.sort(ref numbers, 0, n - 1);
            Terminal.printArray("QuickSort", numbers);

            /*LinearSearch linear = new LinearSearch(numbers);
            n = 11;
            int index=linear.find(n);
            if (index < 0)
            {
                Console.WriteLine("Target value not found.");
            }
            else
            {
                string s1 = "The Target value was found at location {0}.";
                s1 = string.Format(s1, index);
                Console.WriteLine(s1);
            }*/

            /*var bSort = new BinarySearch();
            //int index=bSort.NonRecursiveBinarySearch(ref numbers, 22);
            int index = bSort.RecursiveBinarySearch(ref numbers, 22,0,numbers.Length);
            if (index < 0)
            {
                Console.WriteLine("Target value not found.");
            }
            else {
                string s = "The Target value was found at location {0}.";
                s=string.Format(s,index);
                Console.WriteLine(s);
            }*/


            /*DP.Fibonacci f = new DP.Fibonacci();
            string s = "fibo({0}) => {1}";
            n = 8;
            s=string.Format(s, n, f.fibo(n));
            Console.WriteLine(s);
            */


            Console.ReadKey();
        }
    }
}
