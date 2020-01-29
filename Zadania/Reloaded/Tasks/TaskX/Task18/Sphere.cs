using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task18
{
    public class Sphere : ICalculateVolumes
    {
        double Radius { get; set; }
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public double CalculateVolume()
        {
            return 4.0 / 3 * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
