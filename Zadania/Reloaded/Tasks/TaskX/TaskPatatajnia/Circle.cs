﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.TaskPatatajnia
{
    class Circle
    {
        public int XCircleMove { get; set; }
        public int YCircleMove { get; set; }
        public bool End { get; set; }
        
        private int _width;
        private int _height;
        private int _circleSize;
        private int _widthRec;
        private Circle _end;

        public Circle(int width, int height, int circleSize, int widthRec, Circle end)
        {
            _width = width;
            _height = height;
            _circleSize = circleSize;
            _widthRec = widthRec;
            _end = end;
            XCircleMove = 2;
            YCircleMove = -3;
            //_end.End = false;
        }
        public Circle()
        {
           
        }
       

        public void CircleColision(int circX, int circY, int recX, int recY)
        {
            
            if (circX < 1)
            {
                XCircleMove = -XCircleMove;
            }
            if (circX > _width - _circleSize - 1) { XCircleMove = -XCircleMove; }

            if (circY < 1) { YCircleMove = -YCircleMove; }

            if (circY > _height - _circleSize - 1)
            {
                if (circX + _circleSize / 2 > recX && circX + _circleSize / 2 < recX + _widthRec)
                {
                    YCircleMove = -YCircleMove;
                }
                else
                {
                    Console.WriteLine("You lose");
                    Console.ReadKey();
                    _end.End = true;
                   
                }
            }
        //}public int EndProg()
        //{
        //    if (_end==1) { return 1; }
           
        //    else { return 0; }
           
        }
    }
}
