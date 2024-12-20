﻿using System;
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

            /*BubbleSort search = new BubbleSort();
            search.sort(ref numbers);
            Terminal.printArray(ref numbers);*/

            /*var sort = new MergeSort();
            var sortedArray = sort.SortArray(numbers, 0, numbers.Length - 1);
            Terminal.printArray(ref sortedArray);*/

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


            /*QuickSort qSort = new QuickSort();
            qSort.sort(ref numbers,0,numbers.Length-1);
            Terminal.printArray(ref numbers);*/

            int[,] graph = new int[,]
            {
                { 0, 2, 0, 6, 0 },
                { 2, 0, 3, 8, 5 },
                { 0, 3, 0, 0, 7 },
                { 6, 8, 0, 0, 9 },
                { 0, 5, 7, 9, 0 },
            };

            /*Greedy.Prim prim = new Greedy.Prim();
            prim.Run(graph);*/
            
            Backtrack.NQueen nQueen = new Backtrack.NQueen();
            nQueen.SolveNQueens(8);

            Console.ReadKey();
        }
    }
}
