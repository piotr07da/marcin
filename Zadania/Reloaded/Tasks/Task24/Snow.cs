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
        
        public Snow()
        {

        }
        public Snow(Random random)
        {
            _random = random;
           
        }
        public Vector Position { get; set; }
        public Vector Move { get; set; }
        public Vector Back { get; set; }
        public int GroundSnow { get; set; }
       
       
        Draving draw = new Draving();
        public void Start(Snow snow, int firstspace, int space, int flake,int i,int a)
        {
            snow.Position = new Vector();
            snow.Move = new Vector();
           

            snow.Move.Y = _random.Next(2, 5);

            snow.Position.X = SPosition(firstspace, space, flake, i);
            snow.Position.Y = SPosition(firstspace, space, flake, i=-a);

           
        }
         
        public void SMove(Snow snow,int flakeSize,int width,int height,Wind wind)
        {
            
            snow.Back = new Vector();
            snow.Back = snow.Position.CreateCopy();
            snow.Move.X = _random.Next(-2, 2);
            snow.Move.X = snow.Move.X + wind.Strength;

            snow.Position = snow.Position + snow.Move;

            if (snow.Position.Y > snow.Move.Y + 1)
            {

                if (snow.Back.X >  1 && snow.Back.X < width  - 1 - flakeSize)
                {

                    draw.DelSnow(snow, flakeSize);
                }

                if (snow.Position.X >  1 && snow.Position.X < width  - 1 - flakeSize)
                {

                    draw.DSnow(snow, flakeSize);
                }
                else
                {
                    if (snow.Position.X > width -  1 - flakeSize)
                    {
                        snow.Position.X = (snow.Move.X+ snow.Position.X) % width ;
                    }
                    else
                    {
                        snow.Position.X = snow.Position.X + width - 1 - flakeSize;
                    }

                }
                if (snow.Position.Y > height - 1 - flakeSize - snow.Move.Y - snow.GroundSnow) 
                {
                    snow.Position.Y = (snow.Position.Y + snow.Move.Y + flakeSize + snow.GroundSnow) % height;
                    snow.GroundSnow += (6 - Convert.ToInt32(snow.Move.Y));
                }
            }
           
           
        }



        private double SPosition(int firstspace, int space, int flakeSize,int i)
        {
            return firstspace + space * i + _random.Next(-flakeSize, flakeSize) - flakeSize / 2;
        }
    }
}
