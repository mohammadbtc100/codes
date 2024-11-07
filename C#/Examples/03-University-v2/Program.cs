using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Core {
        public string readValue(string prompt) {
            prompt = "Enter " + prompt + " : ";
            Console.Write(prompt);
            string s = Console.ReadLine();
            return s;
        }
    }
    public class Person:Core {
        //Attributes
        private long nId;
        private string name;
        private int age;
        //Methods(Functions)
        public void setNationalId(long nId) 
        { 
            this.nId = nId; 
        }
        public long getNationalId() {
            return nId;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        //Constructr
        public Person() {
            nId= 0;
            name = "Nothing...";
            age = 0;
        }
    }
    public class Student : Person
    {
        //Attrites
        private int sId;
        private string field;
        //Constructor
        public Student()
        {
            this.sId = 0;
            this.field = "Computer";
        }
        //Methods
        public void setStudentId(int sid)
        {
            this.sId = sid;
        }
        public int getStudentId()
        {
            return sId;
        }
        public void setField(string field)
        {
            this.field = field;
        }
        public string getField()
        {
            return field;
        }
    }
    public class Player : Student{
        private string sport;
        public void setSport(string sport)
        {
            this.sport = sport;
        }
        public string getSport() { 
            return sport;
        }
        public Player() {
            sport = "Football";
        }
        public void report() {
            /*Console.WriteLine("SId  : "+getStudentId());
            Console.WriteLine("NId  : " + getNationalId());
            Console.WriteLine("Name : " + getName());
            Console.WriteLine("Age  : " + getAge());
            Console.WriteLine("Filed: " + getField());
            Console.WriteLine("Sport: " + getSport());*/

            int _sid = getStudentId();
            long _nid = getNationalId();
            string _name = getName();
            int _age = getAge();
            string _filed = getField();
            string _sport = getSport();
            string str = "SId  : {0}\nNId  : {1}\nName : {2}\nAge  : {3}\nFiled: {4}\nSport: {5}";
            str = string.Format(str, _sid,_nid,_name,_age,_filed,_sport);
            Console.WriteLine(str);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            int n;
            long m;
            string s;

            s = player.readValue("StudentId");
            n = int.Parse(s);
            player.setStudentId(n);

            s = player.readValue("NationalId");
            m = long.Parse(s);
            player.setNationalId(m);

            s = player.readValue("Name");
            player.setName(s);

            s = player.readValue("Age");
            n = int.Parse(s);
            player.setAge(n);

            player.report();

            Console.ReadKey();

        }
    }
}
