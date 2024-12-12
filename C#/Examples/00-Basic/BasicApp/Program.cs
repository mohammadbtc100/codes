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
            for(int i=2; i<=20; i = i + 2)
            {
                if(i==8)
                    continue; // jump to for
                if (i == 18)
                    break;    //exit of for
                Console.Write(i+" ");
            }

            Console.ReadKey();
        }
    }
}
