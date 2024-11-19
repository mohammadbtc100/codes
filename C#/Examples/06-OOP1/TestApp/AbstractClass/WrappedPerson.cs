using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.AbstractClass
{
    public class WrappedPerson : Person
    {
        public WrappedPerson(int id,string name,int age):base(id,name,age) { 
            
        }
        public override void showDetails()
        {
            Console.WriteLine("Id   : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age  : " + Age);
        }
    }
}
