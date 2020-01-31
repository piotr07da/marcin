using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Reloaded.Tasks.Task28
{
    public class Drawing
    {
        private readonly Graphics _graph;
        private readonly SolidBrush _greenBrush;
        private readonly Pen _greenPen;
        private readonly SolidBrush _blackBrush;

        private const int xOffset = 100;
        private const int yOffset = 250;

        private int _width;
        private int _height;
       


        public Drawing(int width, int height)
        {
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            _graph = Graphics.FromHwnd(hwnd);
            _greenBrush = new SolidBrush(Color.Green);
            _greenPen = new Pen(_greenBrush);
            _blackBrush = new SolidBrush(Color.Black);
            _width = width;
            _height = height;
            
        }
        public void FirstDraw()
        {
            _graph.Clear(Color.Black);
            _graph.DrawRectangle(_greenPen, xOffset, yOffset, _width, _height);
        }

        public void DrawObject(int x, int y, int tool, int sizeObject)
        {
            if (tool == 1)
            {
                _graph.FillRectangle(_blackBrush, x + xOffset, y + yOffset, sizeObject, sizeObject);
            }
            if (tool == 2)
            {
                _graph.DrawLine(_greenPen, x + xOffset, y + yOffset, x + xOffset + 1, y + yOffset);
              
            }
            if (tool == 3)
            {
                _graph.FillEllipse(_greenBrush, x + xOffset, y + yOffset, sizeObject, sizeObject);
                
            }
            if (tool == 4)
            {
                _graph.FillRectangle(_greenBrush, x + xOffset, y + yOffset, sizeObject, sizeObject);
            }
        }
    }
}
