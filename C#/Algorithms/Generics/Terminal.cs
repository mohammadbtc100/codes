using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Generics
{
    public static class Terminal
    {
        public static void printArray(ref int[] array) { 
            array.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
