using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.AbstractClass;

namespace TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Context partial = new Context(1,"Moses");
            partial.showPartial();*/

            //Abstract Class
            /*WrappedPerson wrappedPerson = new WrappedPerson(1,"Moses",20);
            wrappedPerson.showDetails();*/

            Interface.Person person=new Interface.Person(1,"Moses",19);
            person.showDetails();

            Console.ReadKey();
        }
    }
}
