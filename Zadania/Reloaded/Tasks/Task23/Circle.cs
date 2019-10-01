using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Reloaded.Tasks.Task23
{

    public class Circle
    {
        public Circle()
        {
            MoveX = 2;
            MoveY = 1;
        }
        public Drawing draw = new Drawing();

        public  int MoveX { get; set; }
        public  int MoveY { get; set; }        
        public int Diameter { get; set; }
        public int X { get; set; }
        public int BackX { get; set; }
        public int BackY { get; set; }
        public int Y { get; set; }        

        public void Start(Circle circle, int width, int height,List<Circle> circlList)
        {
            bool colision=false;

            for(; ; )
            {
                Random random = new Random();
                circle.Diameter = random.Next(10, 40);
                circle.X = random.Next(120, width + 80 - circle.Diameter);
                circle.Y = random.Next(120, height + 80 - circle.Diameter);

                foreach (var item in circlList)
                {   if (circle != item)
                    {
                        if ((circle.X < item.X + item.Diameter && circle.X + circle.Diameter > item.X) && (circle.Y < item.Y + item.Diameter && circle.Y + circle.Diameter > item.Y)) { colision = true; }
                    }
                    
                }
                if (colision == false) { break; }
                Thread.Sleep(10);
            }
           

            draw.DrawCirc(circle);
        }
        public void Move(Circle circle, int width, int height, List<Circle> circList)
        {

            circle.BackX = circle.X;
            circle.BackY = circle.Y;

            if (circle.X >= 99 + width - circle.Diameter) {  circle.MoveX = -circle.MoveX; }
            if (circle.X <= 101) { circle.MoveX = -circle.MoveX; }
            if (circle.Y >= 100 + height - circle.Diameter) { circle.MoveY = -circle.MoveY; }
            if (circle.Y <= 100) { circle.MoveY = -circle.MoveY; }

            Colision(circle, circList);

            circle.X = circle.X + circle.MoveX;
            circle.Y = circle.Y + circle.MoveY;
                        
            draw.DelCirc(circle);
            draw.DrawCirc(circle);

        }
        private void Colision(Circle circle, List<Circle> circList)
        {
            foreach (var item in circList)
            {
                if (circle != item)
                {
                    if ((circle.X < item.X + item.Diameter && circle.X + circle.Diameter > item.X) && (circle.Y < item.Y + item.Diameter && circle.Y + circle.Diameter > item.Y))
                    {
                        circle.MoveX = -circle.MoveX;
                        circle.MoveY = -circle.MoveY;
                        item.MoveX = -item.MoveX;
                        item.MoveY = -item.MoveY;
                    }
                }
            }
        }
    }
}
