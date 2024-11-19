using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Interface
{
    public interface IPerson
    {
        void setId(int id);
        void setname(string name);
        void setAge(int age);
        int getId();
        string getName();
        int getAge();
        void showDetails();
    }
}
