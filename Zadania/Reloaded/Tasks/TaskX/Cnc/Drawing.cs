using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace Reloaded.Tasks.TaskX.Cnc
{
    public class Drawing
    {
        private readonly Graphics _graphics;
        private const int xOffset = 100;
        private const int yOffset = 100;
        public Drawing()
        {
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            _graphics = Graphics.FromHwnd(hwnd);
        }
        public void Rect(int width, int height, int xPoz, int yPoz)
        {           
            var yellowBrush = new SolidBrush(Color.Yellow);
            var yellowPen = new Pen(yellowBrush);
            _graphics.DrawRectangle(yellowPen, xOffset + xPoz, yOffset + yPoz, width, height);
        }
        public void Del()
        {
            _graphics.Clear(Color.Black);
        }
        public void Circ()
        {
            var whiteBrush = new SolidBrush(Color.Red);
            _graphics.FillEllipse(whiteBrush,121+xOffset,168+yOffset,2,2);
        }
    }
}
