using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class Cylinder : ICubature
    {
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }
        public double Radius { get; set; }
        public double Height { get; set; }

        public double CalculateCubature()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
}
