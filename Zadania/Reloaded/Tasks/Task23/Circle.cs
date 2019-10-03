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
        private const int margin = 20;
        int weight = 50;
        private readonly Random _random;
        

        public Circle()
        {
            //MoveX = 2;
            //MoveY = 1;
            _random = new Random();

        }
        public Drawing draw = new Drawing();

        //public int RX { get; set; }
        //public int RY { get; set; }
        public  int MoveX { get; set; }
        public  int MoveY { get; set; }        
        public int Diameter { get; set; }
        public int X { get; set; }
        public int BackX { get; set; }
        public int BackY { get; set; }
        public int Y { get; set; }        

        public void Start(Circle circle, int width, int height,List<Circle> circlList,int x, int y)
        {
            bool colision=false;
            Random random = new Random();

            for (; ; )
            {                
                circle.Diameter = random.Next(10, 40);
                circle.X = random.Next(x+margin, width + x-margin - circle.Diameter);
                circle.Y = random.Next(y+margin, height + y-margin - circle.Diameter);

                foreach (var item in circlList)
                {   if (circle != item)
                    {
                        if (!(ColisionObject(circle, item))) {colision =false ; }
                    }
                   
                }
                if (!(colision)) { break; }
                //Thread.Sleep(10);
            }
           

            draw.DrawCirc(circle);

            circle.MoveX = random.Next(1, 5);
            Thread.Sleep(20);
            circle.MoveY = random.Next(1, 5);
            Thread.Sleep(20);



        }
        public void Move(Circle circle, int width, int height, List<Circle> circList,int x,int y)
        {
           
            circle.BackX = circle.X;
            circle.BackY = circle.Y;

            Colision(circle, circList);

            if (circle.X >= x-circle.MoveX + width - circle.Diameter) {  circle.MoveX = -circle.MoveX; }
            if (circle.X <= x-circle.MoveX) { circle.MoveX = -circle.MoveX; }
            if (circle.Y >= y-circle.MoveY + height - circle.Diameter) { circle.MoveY = -circle.MoveY; }
            if (circle.Y <= y-circle.MoveY) { circle.MoveY = -circle.MoveY; }

           
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
                    //ColisionObject(circle, item);

                    if (ColisionObject(circle,item))
                    {
                        //circle.MoveX = -circle.MoveX;
                        //circle.MoveY = -circle.MoveY;
                        //item.MoveX = -item.MoveX;
                        //item.MoveY = -item.MoveY;

                        var v = new VectorMath();

                        var v1 = new Vector(circle.MoveX, circle.MoveY);
                        var v2 = new Vector(item.MoveX, item.MoveY);

                        var x1 = new Vector(circle.X, circle.Y);
                        var x2 = new Vector(item.X, item.Y);

                        int weights = (2 * item.Diameter) / (circle.Diameter + item.Diameter);
                        int weights2 = (2 * circle.Diameter) / (circle.Diameter + item.Diameter);
                        double patatajnia = (v.DotProduct(v.VectorSub(v1, v2), v.VectorSub(x1, x2)) / ((v.Lenght(v.VectorSub(x1, x2))) * (v.Lenght(v.VectorSub(x1, x2)))));
                        double patatajnia2 = (v.DotProduct(v.VectorSub(v2, v1), v.VectorSub(x2, x1)) / ((v.Lenght(v.VectorSub(x2, x1))) * (v.Lenght(v.VectorSub(x2, x1)))));

                        v1 = v.VectorSub(v1, v.Mul(v.VectorSub(x1, x2), (weights * patatajnia)));
                        v2 = v.VectorSub(v2, v.Mul(v.VectorSub(x2, x1), (weights * patatajnia)));

                        circle.MoveX = Convert.ToInt32(v1.VX);
                        circle.MoveY = Convert.ToInt32(v1.VY);
                        item.MoveX = Convert.ToInt32(v2.VX);
                        item.MoveY = Convert.ToInt32(v2.VY);
                    }
                }
            }
        }
        private bool ColisionObject(Circle circle,Circle item)
        {
            if ((circle.X < item.X + item.Diameter && circle.X + circle.Diameter > item.X) && (circle.Y < item.Y + item.Diameter && circle.Y + circle.Diameter > item.Y))
            {
                return true;
            }
            else { return false; }
        }
    }
}
