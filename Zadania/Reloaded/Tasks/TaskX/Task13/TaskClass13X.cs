using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reloaded.Tasks.TaskX.Task13
{
    public class TaskClass13X
    {
        public void Test()
        {
            var rec1 = new RectangleX(2.1, 2.5);
            var rec2 = new RectangleX(3.1, 3.5);
            var rec3 = new RectangleX(4.1, 4.5);
            var rec4 = new RectangleX(5.1, 5.5);

            List<RectangleX> recList = new List<RectangleX>();

            recList.Add(rec1);
            recList.Add(rec2);
            recList.Add(rec3);
            recList.Add(rec4);

            var cir1 = new CircleX(1);
            var cir2 = new CircleX(2);
            var cir3 = new CircleX(3);
            var cir4 = new CircleX(4);

            List<CircleX> circList = new List<CircleX>();

            circList.Add(cir1);
            circList.Add(cir2);
            circList.Add(cir3);
            circList.Add(cir4);

            foreach (var item in recList)
            {
                item.Scale(7.77);
            }

            foreach (var item in circList)
            {
                item.Scale(7.77);
            }


            //var rectangleX = new RectangleX();
            //var consoleWalueReaderX = new ConsoleValueReaderX();
            //var circleX = new CircleX();

            //rectangleX.Width = consoleWalueReaderX.ReadDouble("Wpisz szerokość : ");

            //rectangleX.Height = consoleWalueReaderX.ReadDouble("Wpisz wysokość : ");

            //rectangleX.Scale(consoleWalueReaderX.ReadDouble("Wpisz skalę : "));

            ////double calculateArea = rectangleX.CalculateArea();

            //Console.WriteLine("Pole prostokąta to : " + rectangleX.CalculateArea());
            //Console.ReadKey();

            //Console.Clear();

            //circleX.CircleRadius = consoleWalueReaderX.ReadDouble("Wpisz promień : ");
            //circleX.Scale(consoleWalueReaderX.ReadDouble("Wpisz skalę : "));
            //Console.WriteLine("Pole koła to : "+ circleX.CircleArea());
            //Console.ReadKey();
        }
    }
}
