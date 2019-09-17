using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class Sphere : ICubature
    {
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public double CalculateCubature()
        {
            return 1.33 * Math.PI * Math.Pow(Radius, 3); // zamiast 1,33 miałem (4/3) albo 4/3 i sobie nie radził ??
        }
    }
}
