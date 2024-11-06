using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
    internal class Calculation
    {
        public static int read()
        {
            string value;
            int x;
            Console.Write("Enter a num : ");
            value = Console.ReadLine();
            //string to int
            x = int.Parse(value);
            return x;
        }
        public static float average(int a, int b, int c)
        {
            float avg;
            //type casting
            avg = (float)(a + b + c) / 3;
            return avg;
        }
        public static void printAverage(int a, int b, int c, float avg)
        {
            //string formating
            string s = string.Format("Average of {0},{1} and {2} equal by {3}"
                , a, b, c, avg.ToString("F2"));
            Console.WriteLine(s);
        }
        public void aboutUs() {
            Console.WriteLine("Computer Engineering Students of Skill National University\r\n...");
        }
    }
}
