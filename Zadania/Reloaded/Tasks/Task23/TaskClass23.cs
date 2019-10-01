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
            List<Circle> circList = new List<Circle>();

            Random random = new Random();
                       
            var circle1 = new Circle();
            var circle2 = new Circle();
            var circle3 = new Circle();
            var circle4 = new Circle();
            var circle5 = new Circle();

            circList.Add(circle1);
            circList.Add(circle2);
            circList.Add(circle3);
            circList.Add(circle4);
            circList.Add(circle5);

            var draw = new Drawing();

            int width = random.Next(400, 600);
            int height = random.Next(200, 300);
            int delay = random.Next(5, 10);

            int x = 100;
            int y = 100;

            draw.DrawRect(width, height, x, y);

            foreach (var item in circList)
            {
                item.Start(item, width, height,circList);
                Thread.Sleep(25);
            }

            for (; ; )
            {
                foreach (var item in circList)
                {
                    item.Move(item, width, height, circList);
                    Thread.Sleep(delay);
                }
                            
            }

        }
       
    }
}
