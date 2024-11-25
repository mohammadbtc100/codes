using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int[] numbers = DbContext.numbers;
            int n = numbers.Length;
            Terminal.printArray("Array : ",numbers);

            /*BubbleSort search = new BubbleSort();
            search.sort(ref numbers);
            Terminal.printArray("BubbleSort",numbers);*/

            var sort = new MergeSort();
            sort.mergeSort(numbers, 0, n - 1);
            Terminal.printArray("MergeSort",numbers);

            /*QuickSort qSort = new QuickSort();
            qSort.sort(ref numbers, 0, n - 1);
            Terminal.printArray("QuickSort", numbers);*/





            /*var bSort = new BinarySearch();
            int index=bSort.NonRecursiveBinarySearch(ref numbers, 22);
            int index = sort.RecursiveBinarySearch(ref numbers, 22,0,numbers.Length);
            if (index < 0)
            {
                Console.WriteLine("Target value not found.");
            }
            else {
                string s = "The Target value was found at location {0}.";
                s=string.Format(s,index);
                Console.WriteLine(s);
            }*/

            Console.ReadKey();
        }
    }
}
