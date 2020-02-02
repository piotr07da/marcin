using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Reloaded.Tasks.TaskX.TaskPatatajnia
{
    class Drawing
    {
        private Graphics _graph;
        private const int _xOffset = 100;
        private const int _yOffset = 200;
        private int _width;
        private int _height;
        private int _circleSize;
        private int _widthRec;
        private int _heightRec;

        public Drawing(int width, int height, int circleSize, int widthRec, int heightRec)
        {
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;
            _graph = Graphics.FromHwnd(hwnd);
            _width = width;
            _height = height;
            _circleSize = circleSize;
            _widthRec = widthRec;
            _heightRec = heightRec;
        }
        public void DrawSquar()
        {
            _graph.Clear(Color.Black);
            var blueBrush = new  SolidBrush(Color.Blue);
            var bluePen = new Pen(blueBrush);
            var redBrush = new SolidBrush(Color.Red);
            var redPen = new Pen(redBrush);

            _graph.DrawRectangle(bluePen, _xOffset, _yOffset, _width, _height);
            _graph.DrawLine(redPen, _xOffset, _yOffset + _height, _xOffset + _width, _yOffset + _height);
        }
        public void DrawCircle(int x,int y)
        {
            var yellowBrush = new SolidBrush(Color.Yellow);

            _graph.FillEllipse(yellowBrush, _xOffset + x, _yOffset + y, _circleSize, _circleSize);
        }
        public void DrawRect(int x, int y)
        {
            var yellowBrush = new SolidBrush(Color.Yellow);
            _graph.FillRectangle(yellowBrush, _xOffset + x, _yOffset + y, _widthRec, _heightRec);
        }
        public void DelCircle(int x, int y)
        {
            var blackBrush = new SolidBrush(Color.Black);
            _graph.FillEllipse(blackBrush, _xOffset + x, _yOffset + y, _circleSize, _circleSize);
        }
        public void DelRect(int x,int y)
        {
            var blackBrush = new SolidBrush(Color.Black);
            _graph.FillRectangle(blackBrush, _xOffset + x, _yOffset + y, _widthRec, _heightRec);
        }
        public void DrawLine()
        {
            var redBrush = new SolidBrush(Color.Red);
            var redPen = new Pen(redBrush);
            _graph.DrawLine(redPen, _xOffset, _yOffset + _height, _xOffset + _width, _yOffset + _height);
        }
    }
}
