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
            // Pobieram uchwyt okna aplikacji konsolowej. Uchwyt czyli takie jakby odniesienie do okna w Windows, a w tym przypadku okna z bieżącego procesu w Windows czyli naszej aplikacji konsolowej.
            var hwnd = Process.GetCurrentProcess().MainWindowHandle;

            // Tworzymy obiekt klasy Graphics do rysowania w oknie wskazanym przez zmienną hwnd, która wskazuje na okno w Windows.
            var g = Graphics.FromHwnd(hwnd);

            // "Pędzle" w różnych kolorach
            var aquamarineBrush = new SolidBrush(Color.Aquamarine);
            var redBrush = new SolidBrush(Color.Red);

            // Obiekty klasy Pen - służą do rysowania obramowań różnych kształtów albo do rysowania linii
            var aquamarinePen = new Pen(aquamarineBrush);
            var purplePen = new Pen(redBrush, 1);

            // angielskie Draw = polskie Rysuj czyli w tym przypadku rysujemy prostokąt. Używamy do tego obiektu klasy Pen, podajemy jaki prostokąt czyli w jakim punkcie i jaki duży narysować.
            g.DrawRectangle(aquamarinePen, new Rectangle(new Point(200, 200), new Size(250, 150)));

            var s1 = new Size(10, 10);
            var r1 = new Rectangle(new Point(50, 50), s1);

            // angielskie Fill = polskie Wypełnij czyli w tym przypadku też rysujemy prostokąt tylko tym razem wypełniony. Dlatego też tutaj nie podajemy Pen tylko Brush bo Pen jest do rysowania linii, a Brush to tak właściwie reprezentuje po prostu kolor.
            g.FillRectangle(aquamarineBrush, r1);
            g.DrawRectangle(purplePen, r1);

            DrawFilledAzureRect5x5(g, 300, 300);
            DrawFilledAzureRect5x5(g, 320, 305);

            // Rysujemy linie, zobacz co znaczy, który parametr.
            g.DrawLine(purplePen, 0, 10, 400, 200);

            Console.ReadKey();
        }

        private void DrawFilledAzureRect5x5(Graphics graphics, int x, int y)
        {
            graphics.FillRectangle(new SolidBrush(Color.Azure), new RectangleF(x, y, 5, 5));
        }

    }
}
