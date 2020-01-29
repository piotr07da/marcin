using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16
{
    public class Class16
    {
        public void Test()
        {
            List<IScalable> scalables = new List<IScalable>();

            var rect1 = new Rectangle(2, 2);
            var rect2 = new Rectangle(3, 3);
            var rect3 = new Rectangle(4, 4);

            var circ1 = new Circle(2);
            var circ2 = new Circle(3);
            var circ3 = new Circle(4);

            scalables.Add(rect1);
            scalables.Add(rect2);
            scalables.Add(rect3);

            scalables.Add(circ1);
            scalables.Add(circ2);
            scalables.Add(circ3);

            double scale = 2;

            //for (int i = 0; i < scalables.Count; i++)
            //{
            //    scalables[i].Scale(scale);
            //}

            //foreach (var circle in scalables)
            //{
            //    circle.Scale(scale);
            //}
            foreach (var item in scalables)
            {
                item.Scale(scale);
            }

        }
    }
}
