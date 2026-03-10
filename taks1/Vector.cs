using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks1
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public string Verbose()
        {
            return String.Format("{0} {1} {2}", this.x = x, this.y = y, this.z = z);
        }
    }
}
