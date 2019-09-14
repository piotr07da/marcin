using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task13
{
    public class CircleX
    {
        public CircleX(double circleRadius)
        {
            CircleRadius = circleRadius;
        }
        public double CircleRadius { get; set; }

        public double CircleArea()
        {
            double pi = Math.PI;
            return Math.Pow(CircleRadius, 2) * pi;
        }
        public void Scale(double factor)
        {
            CircleRadius = CircleRadius * factor;
        }
    }
}
