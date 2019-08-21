using Simul.Engine;

namespace Simul.World
{
    public class WorldSettings
    {
        public Vector2 Size { get; set; }

        public Vector2 SizeDiv2
        {
            get
            {
                return new Vector2(Size.X / 2.0, Size.Y / 2.0);
            }
        }
    }
}
