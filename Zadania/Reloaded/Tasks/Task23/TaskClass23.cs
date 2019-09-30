using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Reloaded.Tasks.Task23
{
    public class TaskClass23
    {

        public void Test()
        {
            Random random = new Random();

            var circle1 = new Circle();

            var draw = new Drawing();

            int width = random.Next(400, 600);
            int height = random.Next(200, 300);

            int x = 100;
            int y = 100;

            draw.DrawRect(width, height, x, y);

           
            for (; ; )
            {
                circle1.Radius = random.Next(5, 20);

                CircleStart(circle1, width, height);

                draw.DrawCirc(circle1);

                //Thread.Sleep(10);

                Console.ReadKey();
            }
        }
        private void CircleStart(Circle circle1, int width, int height)
        {
            Random random = new Random();
            circle1.CircleX = random.Next(120, width + 100 - 20 - circle1.Radius*2);
            circle1.CircleY = random.Next(120, height + 100 - 20 - circle1.Radius*2);
        }
    }
}
