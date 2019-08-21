namespace Simul.Engine
{
    public class Vector2
    {
        public Vector2() { }

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public void Add(Vector2 v)
        {
            X += v.X;
            Y += v.Y;
        }

        public void Scale(double s)
        {
            X *= s;
            Y *= s;
        }

        public void Set(Vector2 v)
        {
            Set(v.X, v.Y);
        }

        public void Set(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
