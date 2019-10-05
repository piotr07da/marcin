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
        private const int x = 100;
        private const int y = 100;


        public void Test()
        {
            List<Circle> circList = new List<Circle>();

           
            Random random = new Random();

            var circle1 = new Circle(random);
            var circle2 = new Circle(random);
            var circle3 = new Circle(random);
            var circle4 = new Circle(random);
            var circle5 = new Circle(random);

            circList.Add(circle1);
            circList.Add(circle2);
            circList.Add(circle3);
            circList.Add(circle4);
            circList.Add(circle5);

            var draw = new Drawing();

            int width = random.Next(400, 600);
            int height = random.Next(200, 300);
            int delay = random.Next(5, 10);

            draw.DrawRect(width, height, x, y);

            var startedCircleList = new List<Circle>();

            foreach (var item in circList)
            {
                item.Start(item, width, height, startedCircleList, x, y);
                startedCircleList.Add(item);
                
            }

            for (; ; )
            {
                foreach (var item in circList)
                {
                    item.Move(item, width, height, circList, x, y);
                    Thread.Sleep(delay);
                }

            }

        }

    }
}
