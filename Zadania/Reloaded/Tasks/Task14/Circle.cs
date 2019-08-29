using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task14
{
    class Circle
    {
        private double _circleRadius;
        
        public double CircleRadius
        {
            get
            {
                return _circleRadius;
            }
            set
            {
                _circleRadius = value;
            }
        }

        public double CircleArea()
        {
            return CircleRadius * CircleRadius * 3.14; //nie wiem czy można jakoś potęgować, albo pobrać pi
        }
    }
}
