﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16
{
    class Circle:IScalable
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
            var pi = Math.PI;

            return Math.Pow(CircleRadius, 2) * pi;
        }
        public void Scale(double factor)
        {
            CircleRadius = CircleRadius * factor;
        }
        public Circle (float CircleRadius)
        {
            this.CircleRadius = CircleRadius;
        }
    }
}
