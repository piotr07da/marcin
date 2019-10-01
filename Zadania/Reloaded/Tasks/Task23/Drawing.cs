using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace Reloaded.Tasks.Task23
{
    public class Drawing
    {
        private readonly Graphics _graph;
        public Drawing()
        {
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            _graph = Graphics.FromHwnd(hwnd);
        }

        public void DrawRect(int width, int height, int x, int y)
        {
            _graph.Clear(Color.Black);

            var blueBrush = new SolidBrush(Color.Blue);

            var bluePen = new Pen(blueBrush);

            _graph.DrawRectangle(bluePen, new Rectangle(new Point(x, y), new Size(width, height)));

        }
        public void DrawCirc(Circle circle)
        {
            var redBrush = new SolidBrush(Color.Red);
            _graph.FillEllipse(redBrush, circle.X, circle.Y, circle.Diameter,circle.Diameter);
        }
        public void DelCirc(Circle circle1)
        {
            var blackBrush = new SolidBrush(Color.Black);
            _graph.FillEllipse(blackBrush, circle1.BackX, circle1.BackY, circle1.Diameter, circle1.Diameter);
        }
       
    }
    
}
