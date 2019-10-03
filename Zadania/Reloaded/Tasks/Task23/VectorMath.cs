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

            vector.VX = a.VX - b.VX;
            vector.VY = a.VY - b.VY;
           
            return vector;
        }
        public double DotProduct(Vector a, Vector b)
        {
            return a.VX * b.VX + a.VY * b.VY;
        }
        public double Lenght(Vector a)
        {
            a.VX = Math.Pow(a.VX,2);
            a.VY = Math.Pow(a.VY, 2);
           
            return Math.Sqrt(a.VX + a.VY);
        }
        public Vector Mul(Vector a, double factor)
        {
            var vector = new Vector();
            vector.VX = a.VX * factor;
            vector.VY = a.VY * factor;
           
            return vector;
        }
    }
}
