using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Reloaded.Tasks.Task24
{
    public class Snow
    {
        private readonly Random _random;
        private int _wind;
        public Snow()
        {

        }
        public Snow(Random random,int wind)
        {
            _random = random;
            _wind = wind;
        }
        public Vector Position { get; set; }
        public Vector Move { get; set; }
        public Vector Back { get; set; }
        public int Wind { get; set; }
        //Snow wind = new Snow();

        Draving draw = new Draving();
        public void Start(Snow snow, int firstspace, int space, int flake,int i,int x,int y,int a)
        {
            snow.Position = new Vector();
            snow.Move = new Vector();
           

            snow.Move.Y = _random.Next(2, 5);

            snow.Position.X = x + SPosition(firstspace, space, flake, i);
            snow.Position.Y = y + SPosition(firstspace, space, flake, i=-a);

            //draw.DSnow(snow, flake);
        }
         
        public void SMove(Snow snow,int flake,int width,int height,int x,int y,int _wind)
        {

            snow.Back = new Vector();
            snow.Back = snow.Position.CreateCopy();
            snow.Move.X = _random.Next(-2, 2);
            snow.Move.X = snow.Move.X + _wind;

            snow.Position = snow.Position + snow.Move;

            if (snow.Position.Y > y + snow.Move.Y+1)
            {

                if (snow.Back.X > x + 1 && snow.Back.X < width + x - 1 - flake)
                {

                    draw.DelSnow(snow, flake);
                }

                if (snow.Position.X > x + 1 && snow.Position.X < width + x - 1 - flake)
                {

                    draw.DSnow(snow, flake);
                }
                else
                {
                    if (snow.Position.X > width + x - 1 - flake)
                    {
                        snow.Position.X = (snow.Position.X % width) + snow.Move.X + flake;
                    }
                    else
                    {
                        snow.Position.X = snow.Position.X + width - 1 - flake;
                    }

                }
                if (snow.Position.Y > height + y - 1 - flake-snow.Move.Y)
                {
                    snow.Position.Y = snow.Position.Y % height + snow.Move.Y ;
                }
            }
           
           
        }



        private double SPosition(int firstspace, int space, int flake,int i)
        {
            return firstspace + space * i + _random.Next(-flake, flake) - flake / 2;
        }
    }
}
