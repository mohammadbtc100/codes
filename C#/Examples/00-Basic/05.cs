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
        
        static void Main(string[] args)
        {
            //get a number
            Console.Write("Enter a num:");
            string str=Console.ReadLine();
            int n=int.Parse(str);
            //operations
            if (n < 1) {
                Console.WriteLine("Error");
                Console.ReadKey();
                return;
            }
            if(n>0)
            {
                Console.Write("1 ");
            }
            for (int i = 5; i < n; i=i+5) { 
                Console.Write(i+" ");
            }
            Console.ReadKey();
        }
    }
}
