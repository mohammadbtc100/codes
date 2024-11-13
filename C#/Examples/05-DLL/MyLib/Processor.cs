using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Processor
    {
        private string type;
        private float speed;
        public void setType(string type)
        {
            this.type = type;
        }
        public void setSpeed(float speed)
        {
            this.speed = speed;
        }
        public string getType()
        {
            return type;
        }
        public float getSpeed()
        {
            return speed;
        }
    }
}
