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
            Console.Write("Enter day of week:");
            string str=Console.ReadLine();
            int n=int.Parse(str);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Shanbe");
                    break;
                case 2:
                    Console.WriteLine("YekShanbe");
                    break;
                case 3:
                    Console.WriteLine("DoShanbe");
                    break;
                case 4:
                    Console.WriteLine("SeShanbe");
                    break;
                case 5:
                    Console.WriteLine("chaharShanbe");
                    break;
                case 6:
                    Console.WriteLine("PanjShanbe");
                    break;
                case 7:
                    Console.WriteLine("Joma");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ReadKey();
        }
    }
}
