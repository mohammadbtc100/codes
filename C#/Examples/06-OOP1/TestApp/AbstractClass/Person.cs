using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.AbstractClass
{
    public abstract class Person
    {
        private int id;
        private string name;
        private int age;
        public Person(int id, string name, int age) {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Id { get { return id; } set { id = value; } }
        public int Age { get { return age; } set { age = value; } }
        public abstract void showDetails();

    }
}
