using System.Diagnostics;
using System.Drawing;

namespace Reloaded.Tasks.Task22.Piotr
{
    public class CellMatrixDrawer
    {
        private readonly Graphics _g;

        public CellMatrixDrawer()
        {
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            _g = Graphics.FromHwnd(hwnd);
        }

        public void Draw(CellMatrix matrix)
        {
            _g.Clear(Color.Black);
            DrawFilledRect(0, 0, matrix.Width * 5, matrix.Height * 5, Color.LightGray);

            for (var x = 0; x < matrix.Width; ++x)
            {
                for (var y = 0; y < matrix.Height; ++y)
                {
                    var state = matrix.GetCellLifeState(x, y);
                    if (state == CellLifeState.Alive)
                    {
                        DrawFilledRect5x5(x, y, Color.DarkOliveGreen);
                    }
                }
            }
        }

        public void DrawFilledRect5x5(int x, int y, Color color)
        {
            DrawFilledRect(x, y, 5, 5, color);
        }

        public void DrawFilledRect(int x, int y, int w, int h, Color color)
        {
            _g.FillRectangle(new SolidBrush(color), new Rectangle(x * 5, y * 5, w, h));
        }
    }
}
