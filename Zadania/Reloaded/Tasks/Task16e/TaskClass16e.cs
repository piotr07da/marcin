using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16e
{
    public class TaskClass16e
    {
        public void Test()
        {
            var vectorMath = new VectorMath();
            var a = new Vector(20, 50, 30);
            var b = new Vector(15, 25, 40);
            var c = new Vector(10, 30, 80);

            var v1 = vectorMath.VectorSum(a, c);
            var v2 = vectorMath.VectorSub(b, c);
            var v3 = vectorMath.CrossProduct(a, b);
            var v4 = vectorMath.DotProduct(a, b);
            var look = vectorMath.Lenght(c);
            vectorMath.Mul(b, 10.5);
            vectorMath.Neg(a);

            var ttt = vectorMath.CrossProduct(a, a);
        }
    }
}
