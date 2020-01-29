using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task27
{
    public class InCircle
    {
        private int middleOfCircleX = 0;
        private int middleOfCircleY = 0;
        private int r = 50;
        public bool IsInCircle(int x, int y)
        {
            if ((Math.Pow(x, 2) - 2 * x * middleOfCircleX + Math.Pow(middleOfCircleX, 2)) + (Math.Pow(y, 2) - 2 * y * middleOfCircleY + Math.Pow(middleOfCircleY, 2)) <= Math.Pow(r, 2))
            {
                return true;
            }
            else { return false; }
            // (x-a)^2+(y-b)^2=r^2
            
        }
    }
}
