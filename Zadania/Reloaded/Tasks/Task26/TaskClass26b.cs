using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task27
{
    public class TaskClass26b
    {
        public void Test()
        {
            var c1 = new Cylinder(5.45, 7.62);
            var c2 = new Cylinder(6.0, 8.0);
            var c3 = new Cylinder(12.0, 20.0);

            var c1_c2 = - 2.234123 * (22 * Math.PI * c1.Radius * c1.Radius * c1.Height - Math.Pow(Math.PI * c2.Radius * c2.Radius * c2.Height, 2.5)) + 19.19;
            var c2_c1 = - 2.234123 * (22 * Math.PI * c2.Radius * c2.Radius * c2.Height - Math.Pow(Math.PI * c1.Radius * c1.Radius * c1.Height, 2.5)) + 19.19;
            var c3_c1 = - 2.234123 * (22 * Math.PI * c3.Radius * c3.Radius * c3.Height - Math.Pow(Math.PI * c1.Radius * c1.Radius * c1.Height, 2.5)) + 19.19;
        }

        private class Cylinder
        {
            public Cylinder(double radius, double height)
            {
                Radius = radius;
                Height = height;
            }

            public double Radius { get; }
            public double Height { get; }
        }
    }
}
