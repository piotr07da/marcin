using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDisplay.Functions
{
    public class SineFunction : IFunction
    {
        public SineFunction(double freqency, double amplitude)
        {
            _freqency = freqency;
            _amplitude = amplitude;
        }

        private readonly double _freqency;
        private readonly double _amplitude;

        public double Call(double x)
        {
            return _amplitude * Math.Sin(x * 2.0 * Math.PI * _freqency);
        }
    }
}
