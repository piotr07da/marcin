using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task26
{
    class TaskClass26bFixed
    {
        public void Test()
        {
            double a;
            double b;
            double c;

            var c1 = new Cylinder(5.45, 7.62);
            var c2 = new Cylinder(6.0, 8.0);
            var c3 = new Cylinder(12.0, 20.0);

            a = Calculate(c1, c2);
            b = Calculate(c2, c1);
            c = Calculate(c3, c1);
           
        }
        private double Calculate(Cylinder x1, Cylinder x2)
        {
            return -2.234123 * (22 * Math.PI * x1.Radius * x1.Radius * x1.Height - Math.Pow(Math.PI * x2.Radius * x2.Radius * x2.Height, 2.5)) + 19.19;
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
        //c1_c2 54977773.....
        //c2_c1 30075322.....
        //c3_c1 29675087.....
    }
}

