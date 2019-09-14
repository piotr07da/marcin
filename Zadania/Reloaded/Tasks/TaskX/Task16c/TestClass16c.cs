using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16c
{
    public class TestClass16c
    {
        public void Test()
        {
            var linearFunction = new LinearFunction(-10,-12);
            double y = linearFunction.CalculateValue(3);
            double x0 = linearFunction.CalculateTheZeroPlace();
        }
    }
}
