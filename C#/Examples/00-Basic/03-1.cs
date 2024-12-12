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
            Console.Write(msg);
        }
        public static float read() {
            print("Enter a number:");
            string str = Console.ReadLine();
            float n = float.Parse(str);
            return n;
        }
        static void Main(string[] args)
        {
            float x1= read();
            float x2 = read();
            float y= x1 + x2;
            print("Sum is "+y.ToString());
            Console.ReadKey();
        }
    }
}
