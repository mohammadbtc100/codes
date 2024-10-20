using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLab2.Models
{
    internal class Novel
    {
        public int id { get; set; }
        public string name { get; set; }
        public byte[] cover { get; set; }


        public Novel(int id,string name, byte[] cover) {
            this.id = id;
            this.name = name;
            this.cover = cover;
        }
    }
}
