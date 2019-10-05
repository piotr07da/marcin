using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task23
{
    public class Vector
    {
        public Vector() { }
        public Vector(Vector vector)
        {
            X = vector.X;
            Y = vector.Y;
        }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public Vector CreateCopy()
        {
            return new Vector(X, Y);
        }

        public static Vector Zero()
        {
            return new Vector(0, 0);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        public static Vector operator +(Vector a, double value)
        {
            return new Vector(a.X + value, a.Y + value);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }

    }
}
