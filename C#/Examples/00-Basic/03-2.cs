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
        public static void print(string msg,string line) {
            Console.Write(msg+line);
        }
        public static float read() {
            print("Enter a number:","");
            string str = Console.ReadLine();
            float n = float.Parse(str);
            return n;
        }
        public static float getSum(float a, float b) { 
            return a + b;
        }
        public static float getSub(float a, float b)
        {
            return a - b;
        }
        public static float getMult(float a, float b)
        {
            return a * b;
        }
        public static float getDiv(float a, float b)
        {
            return a / b;
        }
        public static float getMod(float a, float b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            float x1= read();
            float x2 = read();

            float sum= getSum(x1, x2);
            float sub = getSub(x1, x2);
            float mult = getMult(x1, x2);
            float div = getDiv(x1, x2);
            float mod = getMod(x1, x2);

            string message = string.Empty,line="\n";
            message = "Sum is "+getSum(x1,x2);
            print(message,line);

            message = "Sub is " + getSub(x1, x2);
            print(message, line);

            message = "Mult is " + getMult(x1, x2);
            print(message, line);

            message = "Div is " + getDiv(x1, x2);
            print(message, line);

            message = "Mod is " + getMod(x1, x2);
            print(message, line);

            Console.ReadKey();
        }
    }
}
