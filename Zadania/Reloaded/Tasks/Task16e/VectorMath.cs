using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16e
{
    public class VectorMath
    {
        public Vector VectorSum(Vector a ,Vector b)
        {
            var vector = new Vector();
            vector.X = a.X + b.X;
            vector.Y = a.Y + b.Y;
            vector.Z = a.Z + b.Z;
            return vector ;
        }
        public Vector VectorSub(Vector a,Vector b)
        {
            var vector = new Vector();
            vector.X = a.X - b.X;
            vector.Y = a.Y - b.Y;
            vector.Z = a.Z - b.Z;
            return vector;
        }
        public Vector CrossProduct(Vector a,Vector b)
        {
            var vector = new Vector();
            vector.X = a.Y * b.Z - a.Z * b.Y;
            vector.Y = a.Z * b.X - a.X * b.Z;
            vector.Z = a.X * b.Y - a.Y * b.X;
            return vector;
        }
        public double DotProduct(Vector a,Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        public Vector Neg(Vector a)
        {
            var vector = new Vector();
            vector.X = -a.X;
            vector.Y = -a.Y;
            vector.Z = -a.Z;
            return vector;

        }
        public Vector Mul(Vector a, double factor)
        {
            var vector = new Vector();
            vector.X = a.X * factor;
            vector.Y = a.Y * factor;
            vector.Z = a.Z * factor;
            return vector;
        }
        public double Lenght(Vector a)
        {
            a.X = Math.Pow(a.X, 2);
            a.Y = Math.Pow(a.Y, 2);
            a.Z = Math.Pow(a.Z, 2);
            return Math.Sqrt(a.X + a.Y + a.Z);
        }

    }
}
