using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task28
{
    public class Class28
    {
        private const int _width = 300;
        private const int _height = 200;
        private const int _sizeObjectLarge = 10;
        private const int _sizeObjectSmall = 1;
        public void Test()
        {
            int xCursorPosition = 1;
            int yCursorPosition = 1;
            int xBackCursorPosition = 1;
            int yBackCursorPosition = 1;
            int sizeObject = _sizeObjectSmall;
            var drawing = new Drawing(_width, _height);
            int tool = 1;


            drawing.FirstDraw();
            for (; ; )
            {
                var consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.D2)
                {
                    sizeObject = _sizeObjectSmall;
                    tool = 2;
                }

                if (tool == 1 || tool == 3 || tool == 4) { sizeObject = _sizeObjectLarge; }

                if (consoleKey == ConsoleKey.D1)
                {
                    if (Check(xCursorPosition, yCursorPosition, sizeObject))
                    {
                        
                        tool = 1;
                    }
                    else
                    {
                        tool = 2;
                        sizeObject = _sizeObjectSmall;
                    }
                }

                if (consoleKey == ConsoleKey.D3)
                {
                    if (Check(xCursorPosition, yCursorPosition, sizeObject))
                    {
                        
                        tool = 3;
                    }
                    else
                    {
                        tool = 2;
                        sizeObject = _sizeObjectSmall;
                    }
                }

                if (consoleKey == ConsoleKey.D4)
                {
                    if (Check(xCursorPosition, yCursorPosition, sizeObject))
                    {
                        
                        tool = 4;
                    }
                    else
                    {
                        tool = 2;
                        sizeObject = _sizeObjectSmall;
                    }
                }
                

                if (consoleKey == ConsoleKey.LeftArrow)   //**********************************************************************************************************************************
                {                                                  //Jeżeli chciałbym to zrobić w innej klasie, to parametry bym musiał przekazać przez metodę? Bo widzę i na logikę i w poprzednim 
                    xBackCursorPosition = xCursorPosition;         //przykładzie, że przez konstruktor nie da rady, czyli trzeba nasrać parametrów do metody?
                    xCursorPosition -= 1;
                    if (xCursorPosition < 1) { xCursorPosition = 1; }

                }
                if (consoleKey == ConsoleKey.RightArrow)
                {
                    xBackCursorPosition = xCursorPosition;
                    xCursorPosition += 1;
                    if (xCursorPosition > _width - sizeObject - 1) { xCursorPosition = _width - sizeObject - 1; }

                }
                if (consoleKey == ConsoleKey.UpArrow)
                {
                    yBackCursorPosition = yCursorPosition;
                    yCursorPosition -= 1;
                    if (yCursorPosition < 1) { yCursorPosition = 1; }

                }
                if (consoleKey == ConsoleKey.DownArrow)
                {
                    yBackCursorPosition = yCursorPosition;
                    yCursorPosition += 1;
                    if (yCursorPosition > _height - sizeObject - 1) { yCursorPosition = _height - sizeObject - 1; }

                }
                drawing.DrawObject(xCursorPosition, yCursorPosition, tool, sizeObject);
            }
        }
        public bool Check(int xCursorPosition, int yCursorPosition, int sizeObject)
        {
            if (xCursorPosition + sizeObject < _width-1  && yCursorPosition + sizeObject < _height-1 ) { return true; }
            else return false;
        }
    }
}
