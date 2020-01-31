using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task28
{
    public class Move
    {
        ConsoleKey consoleKey = new ConsoleKey();
        int xCursorPosition;
        int yCursorPosition;
        int xBackCursorPosition;
        int yBackCursorPosition;
        int sizeObject;
        int width;
        int height;
        public Move(ConsoleKey consoleKey, int xCursorPosition, int yCursorPosition, int xBackCursorPosition, int yBackCursorPosition, int sizeObject, int width, int height)
        {
            this.xCursorPosition = xCursorPosition;
            this.yCursorPosition = yCursorPosition;
            this.xBackCursorPosition = xBackCursorPosition;
            this.yBackCursorPosition = yBackCursorPosition;
            this.width = width;
            this.height = height;
            this.consoleKey = consoleKey;
            this.sizeObject = sizeObject;
        }
        public void MoveTool()
        {
            if (consoleKey == ConsoleKey.LeftArrow)
            {
                xBackCursorPosition = xCursorPosition;
                xCursorPosition -= 1;
                if (xCursorPosition < 1) { xCursorPosition = 1; }

            }
            if (consoleKey == ConsoleKey.RightArrow)
            {
                xBackCursorPosition = xCursorPosition;
                xCursorPosition += 1;
                if (xCursorPosition > width - sizeObject - 1) { xCursorPosition = width - sizeObject - 1; }

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
                if (yCursorPosition > height - sizeObject - 1) { yCursorPosition = height - sizeObject - 1; }

            }
        }
    }
}
