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

        public static Vector operator +(Vector vector1, Vector vector2)
        {

            var newx = vector1.x + vector2.x;
            var newy = vector1.y + vector2.y;
            var newz = vector1.z + vector2.z;
            var vector = new Vector(newx, newy, newz);
            return vector;
        }

        public static Vector operator -(Vector vector1, Vector vector2)
        {

            var newx = vector1.x - vector2.x;
            var newy = vector1.y - vector2.y;
            var newz = vector1.z - vector2.z;

            var vector = new Vector(newx, newy, newz);

            return vector;
        }

    }
}
