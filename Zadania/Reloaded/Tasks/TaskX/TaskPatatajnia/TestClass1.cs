using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Reloaded.Tasks.TaskX.TaskPatatajnia
{
    class TestClass1
    {
        private const int _width = 200;
        private const int _height = 200;
        private const int _circleSize = 10;
        private const int _widthRec = 40;
        private const int _heightRec = 5;
        private const int _rectSpeed = 4;
        int circSpeed = 50;
        int counter = 0;
        int xCirc = 50;
        int yCirc = _height - _circleSize - 1;
        int xRec = 50;
        int yRec = _height;
       
        private Circle _circ; 
        
        public void Test()
        {
           
            var draw = new Drawing(_width, _height,_circleSize,_widthRec,_heightRec);
            _circ = new Circle(_width, _height, _circleSize, _widthRec);
            draw.DrawSquar();
            draw.DrawCircle(xCirc, yCirc);
            draw.DrawRect(xRec, yRec);

            Console.ReadKey();

            var task = CircleMove();

            for (; ; )
            {
                if (_circ.End)
                {
                    break;
                }
                var consoleKey = Console.ReadKey().Key;

                draw.DelRect(xRec, yRec);
                draw.DrawLine();

                if (consoleKey == ConsoleKey.LeftArrow)
                {
                    xRec -= _rectSpeed;
                    if (xRec < _rectSpeed) { xRec = _rectSpeed; }
                }
                if (consoleKey == ConsoleKey.RightArrow)
                {
                    xRec += _rectSpeed;
                    if (xRec > _width - _widthRec - _rectSpeed) { xRec = _width - _widthRec - _rectSpeed; }
                }
                draw.DrawRect(xRec, yRec);

            }
        }
        public async Task CircleMove()
        {           
            var draw = new Drawing(_width, _height, _circleSize, _widthRec, _heightRec);
           

            await Task.Run(() =>
            {
                for (; ; )
                {
                  
                    if ((!(xCirc < 1)) && (!(yCirc > _height - _circleSize - 1)))
                    {
                        draw.DelCircle(xCirc, yCirc);
                    }

                    xCirc = xCirc + _circ.XCircleMove;
                    yCirc = yCirc - _circ.YCircleMove;

                    _circ.CircleColision(xCirc, yCirc, xRec, yRec);

                    if ((!(xCirc < 1)) && (!(yCirc > _height - _circleSize - 1)))
                    {
                        draw.DrawCircle(xCirc, yCirc);
                    }
                                        
                    Thread.Sleep(circSpeed);

                    counter++;
                    if (counter > 50)
                    {
                        circSpeed--;
                        counter = 0;
                    }

                }
            });
        }

    }
}
