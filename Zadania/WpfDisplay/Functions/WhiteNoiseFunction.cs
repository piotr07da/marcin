using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDisplay.Functions
{
    public class WhiteNoiseFunction : IFunction
    {
        public WhiteNoiseFunction(double amplitude)
        {
            _amplitude = amplitude;
        }

        private static readonly Random _rand = new Random();
        private readonly double _amplitude;

        public double Call(double x)
        {
            return (_rand.NextDouble() - .5) * 2 * _amplitude;
        }
    }
}
