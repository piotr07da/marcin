using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTasks.Tasks.Task31
{
    public class Triangle
    {
        public bool CheckTriangle(double a, double b, double c)
        {
            if (a >= b && a >= c)
            {
                return Check(a, b, c);
            }
            else if (b >= a && b >= c)
            {
                return Check(b, a, c);
            }
            else if (c >= a && c >= b)
            {
                return Check(c, a, b);
            }
            else return false;
        }
        private bool Check(double a,double b,double c)
        {
            return a < (b + c);
        }
    }
}
