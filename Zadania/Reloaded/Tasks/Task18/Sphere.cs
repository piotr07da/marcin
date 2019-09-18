using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task18
{
    public class Sphere : ICubature
    {
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public double CalculateCubature()
        {
            return 1.33 * Math.PI * Math.Pow(Radius, 3); // zamiast 1,33 miałem (4/3) albo 4/3 i sobie nie radził ??

            // [PIOTR] nie radził dlatego, że (4 / 3) to jest 32-bitowy INT dzielony przez 32-bitowy INT co w wyniku też daje 32-bitowy INT czyli (4 / 3) = 1 bo jest po prostu ucięta część ułamkowa
            // Dowolna z poniższych opcji powinna zadziałać lepiej:
            // (4.0 / 3) - double dzielony przez int daje double
            // (4 / 3.0) - int dzielony przez double daje double
            // (4.0 / 3.0) - double dzielony przez double daje double
        }
    }
}
