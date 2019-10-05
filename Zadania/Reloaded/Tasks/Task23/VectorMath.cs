using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task23
{
    public class VectorMath
    {
        public Vector VectorSub(Vector a, Vector b)
        {
            var vector = new Vector();

            vector.X = a.X - b.X;
            vector.Y = a.Y - b.Y;
           
            return vector;
        }
        public double DotProduct(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        public double Lenght(Vector a)
        {
            a.X = Math.Pow(a.X,2);
            a.Y = Math.Pow(a.Y, 2);
           
            return Math.Sqrt(a.X + a.Y);
        }
        public Vector Mul(Vector a, double factor)
        {
            var vector = new Vector();
            vector.X = a.X * factor;
            vector.Y = a.Y * factor;
           
            return vector;
        }
    }
}
