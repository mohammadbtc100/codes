using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEnum
{
    internal class Program
    {
        public static string[] person = {"Mohammad","Moses","Ali","Lucas"};
        public static void listByFor() {
            for (int i = 0; i < person.Length; i++) {
                Console.WriteLine(person[i]);
            }
        }
        public static void listByWhile()
        {
            int i = 0;
            while (i < person.Length) {

                Console.WriteLine(person[i++]);
            }
        }
        public static void listByForeach()
        {
            foreach(string item in person) 
            { 
                Console.WriteLine(item); 
            }
            
        }
        public static void listByLambda()
        {
            Array.ForEach(person, item => Console.WriteLine(item));
        }
        public static void listByEnum() {
            //An enumerator object
            IEnumerator ienumerator = person.GetEnumerator();
            while (ienumerator.MoveNext()) {
                Console.WriteLine(ienumerator.Current);
            }
        }

        // with LINQ
        public static void list()
        {
            person.ToList().ForEach(item => Console.WriteLine(item.ToString()));
        }
        public static void search(string value)
        {
            var result= person.Where(item => item.Contains(value));
            result.ToList().ForEach(item => Console.WriteLine(item));
        }
        public static void add(string item)
        {
            person.Append(item);
        }
        public static void update(string item,int index)
        {
            person[3] = item;
        }
        public static string[] reverse() {
            string[] r= person.Reverse().ToArray();
            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skill National University\nYour welcome...");
            string[] a= reverse();
            a.ToList().ForEach(item => Console.WriteLine(item));
            Console.ReadKey();
        }
    }
}
