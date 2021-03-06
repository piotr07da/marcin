﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class Cube : ICubature
    {
        public Cube(double width)
        {
            Width = width;
        }
        public double Width { get; set; }

        public double CalculateCubature()
        {
            return Math.Pow(Width, 3);
        }

    }
}
