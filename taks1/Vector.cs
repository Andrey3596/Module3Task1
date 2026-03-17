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
        public override string ToString()
        {
            return $"{this.x} {this.y} {this.z}";
        }

        public override bool Equals(object? obj)
        {
            Vector other = obj as Vector;
            if (other == null)
                return false;

            return x == other.x && y == other.y && z == other.z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        }

        public double VectorLength()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public static Vector operator /(Vector vector1, Vector vector2)
        {
            var x = vector1.y * vector2.z - vector2.y * vector1.z;
            var y = vector1.z * vector2.x - vector2.z * vector1.x;
            var z = vector1.x * vector2.y - vector2.x * vector1.y;
            Vector vector3 = new Vector(x, y, z);
            return vector3;
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

        public static double operator *(Vector vector1, Vector vector2)
        {

            var newx = vector1.x * vector2.x;
            var newy = vector1.y * vector2.y;
            var newz = vector1.z * vector2.z;
            var sum = newx + newy +  newz;

            return sum;
        }


    }
}
