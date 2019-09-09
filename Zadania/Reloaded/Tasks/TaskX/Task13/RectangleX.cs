using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task13
{
    public class RectangleX
    {
        public double Width { get; set; } 
        public double Height { get; set; }

        public void Scale(double factor)
        {
            Width = Width * factor;
            Height = Height * factor;
        }
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
