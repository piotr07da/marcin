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
        public Vector(double x, double y)
        {
            VX = x;
            VY = y;
        }
        public double VX { get; set; }
        public double VY { get; set; }
    }
}
