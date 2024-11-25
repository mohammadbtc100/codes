using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Generics
{
    public static class Terminal
    {
        public static void printArray(string message,int[] array) {
            Console.Write(message + " : ");
            array.ToList().ForEach(x => Console.Write(x+" "));
            Console.WriteLine();
        }
    }
}
