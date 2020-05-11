using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Cnc
{
    public class ClassCnc
    {
               
        public void Test()
        {
            var draw = new Drawing();

            int y = 0;
            int x = 0;

            for (; ; )
            {
                var key = Console.ReadKey().Key;
                               
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        x -= 1;
                        if (x < -19) x = -19;
                        break;
                    case ConsoleKey.RightArrow:
                        x += 1;
                        if (x > 19) x = 19;
                        break;
                    case ConsoleKey.UpArrow:
                        y -= 1;
                        if (y < -19) y = -19;
                        break;
                    case ConsoleKey.DownArrow:
                        y += 1;
                        if (y > 19) y = 19;
                        break;                                         
                }

                if (key == ConsoleKey.Escape) break;

                draw.Del();

                draw.Rect(44, 108, 100, 100);
                draw.Rect(78, 38, 83, 150+y);
                draw.Rect(38, 38, 103+x, 150+y);
                draw.Circ();
            }
        }
    }
}
