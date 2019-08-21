using System.Collections.Generic;

namespace WpfDisplay.Functions
{
    public class SimpleMovingAverageFunction : IFunction
    {
        public SimpleMovingAverageFunction(IFunction underlayingFunction, int averagedElementCount)
        {
            _function = underlayingFunction;
            _averagedElementCount = averagedElementCount;
            _elementsBuffer = new LinkedList<double>();
        }

        private readonly IFunction _function;
        private readonly int _averagedElementCount;
        private readonly LinkedList<double> _elementsBuffer;

        public double Call(double x)
        {
            var v = _function.Call(x);
            _elementsBuffer.AddFirst(v);
            if (_elementsBuffer.Count > _averagedElementCount)
                _elementsBuffer.RemoveLast();

            var sum = 0.0;
            foreach (var ev in _elementsBuffer)
            {
                sum += ev;
            }
            return sum / _elementsBuffer.Count;
        }
    }
}
