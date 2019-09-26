using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Reloaded.Tasks.Task22
{
    public class Drawing
    {
        public void DrawObjects(int x,int y,Color color)
        {
           
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            var graph = Graphics.FromHwnd(hwnd);

            var yellowBrusch = new SolidBrush(Color.Yellow);
            var blueBrusch = new SolidBrush(Color.Blue);

            DrawFilledAzureRect5x5(graph,x, y,color);


        }
        public void DrawFilledAzureRect5x5(Graphics graphics, int x, int y,Color color)
        {
           
            graphics.FillRectangle(new SolidBrush(color), new RectangleF(x * 5, y * 5, 4, 4));
        }
    }
}
