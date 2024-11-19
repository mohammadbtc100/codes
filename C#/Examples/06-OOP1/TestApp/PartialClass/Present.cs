using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public partial class Context
    {
        public Context() {
            /*id = 0;
            name = "non";*/
            setId(0);
            setName("Moses");
        }
        public void showPartial()
        {
            string str = "Id   : {0}\nName : {1}\n";
            str=string.Format(str, id,name);
            Console.WriteLine(str);
        }
    }
}
