using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Reloaded.Tasks.Task24
{
    public class Draving
    {
        private readonly Graphics _graphics;

        public Draving()
        {
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            _graphics = Graphics.FromHwnd(hwnd);
        }
        public void Rect(int width, int height, int x, int y)
        {
            _graphics.Clear(Color.Black);
            var yellowBrush = new SolidBrush(Color.Yellow);
            var yellowPen = new Pen(yellowBrush);
            _graphics.DrawRectangle(yellowPen, x, y, width, height);
        }
        public void DSnow(Snow snow,int flake)
        {

            var whiteBrush = new SolidBrush(Color.White);
            _graphics.FillEllipse(whiteBrush, Convert.ToSingle(snow.Position.X), Convert.ToSingle(snow.Position.Y), flake, flake);
        }
        public void DelSnow(Snow snow,int flake)
        {

            var blackBrush = new SolidBrush(Color.Black);
            _graphics.FillEllipse(blackBrush, Convert.ToSingle(snow.Back.X), Convert.ToSingle(snow.Back.Y), flake, flake);
        }
    }
}
