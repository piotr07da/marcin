using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    public class DrawingExample
    {
        public void Test()
        {
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            var g = Graphics.FromHwnd(hwnd);

            var aquamarineBrush = new SolidBrush(Color.Aquamarine);
            var redBrush = new SolidBrush(Color.Red);
            var aquamarinePen = new Pen(aquamarineBrush);
            var purplePen = new Pen(redBrush, 1);

            g.DrawRectangle(aquamarinePen, new Rectangle(new Point(200, 200), new Size(250, 150)));

            var s1 = new Size(10, 10);
            var r1 = new Rectangle(new Point(50, 50), s1);
            g.FillRectangle(aquamarineBrush, r1);
            g.DrawRectangle(purplePen, r1);

            DrawFilledAzureRect5x5(g, 300, 300);
            DrawFilledAzureRect5x5(g, 320, 305);

            g.DrawLine(purplePen, 0, 10, 400, 200);

            Console.ReadKey();
        }

        private void DrawFilledAzureRect5x5(Graphics graphics, int x, int y)
        {
            graphics.FillRectangle(new SolidBrush(Color.Azure), new RectangleF(x, y, 5, 5));
        }

    }
}
