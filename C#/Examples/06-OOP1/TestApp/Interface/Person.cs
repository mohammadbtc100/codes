using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestApp.Interface
{
    public class Person : IPerson
    {
        private int id;
        private string name;
        private int age;
        public Person() { }
        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void setAge(int age)
        {
            this.age=age;
        }

        public void setId(int id)
        {
            this.id=id;
        }

        public void setname(string name)
        {
            this.name=name;
        }

        public void showDetails()
        {
            Console.WriteLine("Id   : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age  : " + age);
        }
    }
}
