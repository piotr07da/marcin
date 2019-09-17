using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task17
{
    public class TaskClass17
    {
        public void Test()
        {
            List<IScalable> scalables = new List<IScalable>();
            List<IArea> areas = new List<IArea>();

            var rect1 = new Rectangle(1, 1);
            var rect2 = new Rectangle(2, 2);
            var rect3 = new Rectangle(3, 3);

            var circ1 = new Circle(1);
            var circ2 = new Circle(2);
            var circ3 = new Circle(3);

            scalables.Add(rect1);
            scalables.Add(rect2);
            scalables.Add(rect3);

            scalables.Add(circ1);
            scalables.Add(circ2);
            scalables.Add(circ3);

            areas.Add(rect1);
            areas.Add(rect2);
            areas.Add(rect3);

            areas.Add(circ1);
            areas.Add(circ2);
            areas.Add(circ3);

            double[] area = new double[areas.Count];

            for (int i = 0; i < areas.Count; i++)
            {
                area[i] = areas[i].CalculateArea();
            }

            foreach (var item in scalables)
            {
                item.Scale(2);
            }
        }
    }
}
