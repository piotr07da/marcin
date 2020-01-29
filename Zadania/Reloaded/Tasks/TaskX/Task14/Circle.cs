using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task14
{
    public class Circle
    {
        private double _circleRadius;

        public double CircleRadius
        {
            get { return _circleRadius; }
            set { _circleRadius = value; }
        }
        public double CalculateArea()
        {
            return Math.Pow(CircleRadius,2)*Math.PI ;
        }
        public double Scale(double factor)
        {
            return CircleRadius * factor;
        }
    }
}
