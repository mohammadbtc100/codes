using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicApp
{
    internal class Program
    {
        public static void print(string msg) {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            print("Hye guys");
            string s = "bye";
            print(s);   
            Console.ReadKey();
        }
    }
}
