using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Engine.Collisions
{
    public class CircleCollider
    {
        public CircleCollider(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
    }
}
