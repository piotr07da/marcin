using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task24
{
    public class Vector
    {
        public Vector()
        {

        }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Vector(Vector vector)
        {
            X = vector.X;
            Y = vector.Y;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public Vector CreateCopy()
        {
            return new Vector(X, Y);
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
    }
}
