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

        public void DrawRect(int width, int height, int x, int y)
        {
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            var graph = Graphics.FromHwnd(hwnd);

            var blueBrush = new SolidBrush(Color.Blue);

            var bluePen = new Pen(blueBrush);

            graph.DrawRectangle(bluePen, new Rectangle(new Point(x, y), new Size(width, height)));

        }
        public void DrawCirc(Circle circle1)
        {
            
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            var graph = Graphics.FromHwnd(hwnd);

            var redBrush = new SolidBrush(Color.Red);
            graph.FillPie(redBrush, circle1.CircleX, circle1.CircleY, circle1.Radius,circle1.Radius,0,360);
        }
       
    }
    
}
