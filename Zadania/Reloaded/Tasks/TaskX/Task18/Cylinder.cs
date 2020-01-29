using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task18
{
    public class Cylinder : ICalculateVolumes
    {
        double Radius { get; set; }
        double Height { get; set; }
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }
        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
}
