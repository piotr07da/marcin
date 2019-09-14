using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16c
{
    public class LinearFunction
    {
        public LinearFunction(double a,double b)
        {
            A = a;
            B = b;
        }
        public double A { get; set; }
        public double B { get; set; }

        private bool _orGrowing;
        public bool OrGrowing
        {
            get
            {
                if (A > 0) { _orGrowing = true; }
                else { _orGrowing = false; }
                return _orGrowing;
            }
        }

        private bool _orDescending;
        public bool OrDescending
        {
            get
            {
                if (A < 0) { _orDescending = true; }
                else { _orDescending = false; }
                return _orDescending;
            }
        }
        private bool _orConstant;
        public bool OrConstant
        {
            get
            {
                if (A == 0) { _orConstant = true; }
                else { _orConstant = false; }
                return _orConstant;
            }
        }
        public double CalculateValue(double x)
        {
            return A * x + B;
        }
        public double CalculateTheZeroPlace()
        {
            return -(B / A);
        }
    }
}
