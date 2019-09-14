using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task13
{
    public class RectangleX
    {
        public RectangleX(double width, double height)
        {
            Width = width;
            Height = height;
        }
      
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
        public void Scale(double factor)
        {
            if (factor > 0) 
            {
                Width = Width * factor;
                Height = Height * factor;
            }
        }

    }
}
