using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task18
{
    public class Cube : ICalculateVolumes
    {
        double Width { get; set; }
        public Cube(double width)
        {
            Width = width;
        }
        public double CalculateVolume()
        {
            return Math.Pow(Width, 3);
        }
    }
}
