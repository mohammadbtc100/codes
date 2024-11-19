using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public partial class Context
    {
        private ulong id; 
        private string name;
        public Context(ulong id, string name)
        {
            this.id = id; 
            this.name = name;
        }
        public void setId(ulong id) { 
            this.id = id;
        }
        public ulong getId()
        {
            return this.id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

    }
}
