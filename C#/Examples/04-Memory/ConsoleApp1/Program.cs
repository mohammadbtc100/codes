using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.MyClasses;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClasses.Memory memory = new MyClasses.Memory();
            Memory memory = new Memory();
            memory.setSize(10);
            int size=memory.getSize();
            Console.WriteLine(size.ToString());
            Console.ReadKey();
        }
    }
}
