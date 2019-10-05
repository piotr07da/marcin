using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Reloaded.Tasks.Task23
{

    public class Circle
    {
        private const int margin = 20;
        private const int discFat = 2;
       
        private readonly Random _random;


        public Circle(Random random)
        {
           
            _random = random;

        }
        public Drawing draw = new Drawing();

        
        public Vector Back { get; set; }
        public Vector Position { get; set; }
        public Vector MoveDistance { get; set; }
        public int Density { get; set; }
        public int Diameter { get; set; }
        public double Weight { get; set; }
        public Color Color { get; set; }
         

        public void Start(Circle circle, int width, int height, List<Circle> circlList, int x, int y)
        {
            bool colision = false;
           


            for (; ; )
            {
                
                circle.Diameter = _random.Next(10, 40);
                circle.Density = _random.Next(4, 16);
                int r = 255 / 16 *circle.Density ;
                int g = 255 -r;
                circle.Position = new Vector();
                circle.Position.X = _random.Next(x + margin, width + x - margin - circle.Diameter);
                circle.Position.Y = _random.Next(y + margin, height + y - margin - circle.Diameter);
                circle.Weight = (Math.PI * Math.Pow(circle.Diameter / 2, 2) * discFat)*circle.Density;
                circle.Color = (Color.FromArgb(127,r, g, 0));

                foreach (var item in circlList)

                {
                    
                    if (circle != item)
                    {
                        if (!(ColisionObject(circle, item))) { colision = false; }
                    }

                }
                if (!(colision)) { break; }
              
            }


            draw.DrawCirc(circle);

            circle.MoveDistance = new Vector();
            circle.MoveDistance.X = _random.Next(1, 5);
            
            circle.MoveDistance.Y = _random.Next(1, 5);
           



        }
        public void Move(Circle circle, double width, double height, List<Circle> circList, double x, double y)
        {

            circle.Back = new Vector(circle.Position);

            Colision(circle, circList);

            if (circle.Position.X >= x - circle.MoveDistance.X + width - circle.Diameter) { circle.MoveDistance.X = -circle.MoveDistance.X; }
            if (circle.Position.X <= x - circle.MoveDistance.X) { circle.MoveDistance.X = -circle.MoveDistance.X; }
            if (circle.Position.Y >= y - circle.MoveDistance.Y + height - circle.Diameter) { circle.MoveDistance.Y = -circle.MoveDistance.Y; }
            if (circle.Position.Y <= y - circle.MoveDistance.Y) { circle.MoveDistance.Y = -circle.MoveDistance.Y; }

            circle.Position = circle.Position + circle.MoveDistance;

            draw.DelCirc(circle);
            draw.DrawCirc(circle);

        }
        private void Colision(Circle circle, List<Circle> circList)
        {
            foreach (var item in circList)
            {
                if (circle != item)
                {
                   




                    if (ColisionObject(circle, item))
                    {
                        

                        circle.MoveDistance = NewMoveDistance(circle, item);

                        item.MoveDistance = NewMoveDistance(item, circle);


                        circle.Position = circle.Position + circle.MoveDistance;

                        draw.DelCirc(circle);
                        draw.DrawCirc(circle);
                    }
                }
            }
        }
        private bool ColisionObject(Circle circle, Circle item)
        {
            var v = new VectorMath();
            if (v.Lenght(v.VectorSub(circle.Position, item.Position)) < (circle.Diameter / 2 + item.Diameter / 2))
            {
                return true;
            }
            else { return false; }
        }
        private Vector NewMoveDistance(Circle c1, Circle c2)
        {
            var v = new VectorMath();

            var v1 = c1.MoveDistance;
            var v2 = c2.MoveDistance;

            var x1 = c1.Position;
            var x2 = c2.Position;

            double weights = (2.0 * c2.Weight) / (c1.Weight + c2.Weight);

            double patatajnia = (v.DotProduct(v1 - v2, x1 - x2) / ((v.Lenght(x1 - x2)) * (v.Lenght(x1 - x2))));


            var newMoveDist = v.VectorSub(v1, v.Mul(x1 - x2, (weights * patatajnia)));

            return newMoveDist;

        }
    }
}
