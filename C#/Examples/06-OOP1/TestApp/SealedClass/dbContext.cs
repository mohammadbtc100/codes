using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.SealedClass
{
    public sealed class DbContext
    {
        public DbContext() { }
        public string getList()
        {
            return "List";
        }
        public string serachById(int id)
        {
            return "serachById";
        }
        public string update()
        {
            return "Updated";
        }
        public string delete()
        {
            return "Deleted";
        }
        public string insert()
        {
            return "Inserted";
        }
    }
}




