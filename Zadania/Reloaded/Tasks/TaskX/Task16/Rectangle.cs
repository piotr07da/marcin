﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16
{
    public class Rectangle:IScalable
    {
        

        private double _width;
        private double _height;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public double CalculateArea()
        {
            return Width *  Height;
        }

        public void Scale(double factor)
        {
            Width = Width * factor;
            Height = Height * factor;
        }
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public Rectangle()
        {
                
        }
        

    }

}
