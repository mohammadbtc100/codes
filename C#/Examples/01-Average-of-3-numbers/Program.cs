using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            int a = Calculation.read();
            int b = Calculation.read();
            int c = Calculation.read();
            //Calculation
            float avg = Calculation.average(a,b,c);
            //Output
            Calculation.printAverage(a,b,c,avg);

            Calculation obj=new Calculation();
            obj.aboutUs();

            Console.ReadKey();
        }
    }
}
