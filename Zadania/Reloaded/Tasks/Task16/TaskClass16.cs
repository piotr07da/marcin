using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Tasks.Task13;
using Reloaded.Tasks.Task14;

namespace Reloaded.Tasks.Task16
{
    class TaskClass16
    {
        public void Test()
        {
            var rectangle = new Rectangle ();

            List<Rectangle> rectList = new List<Rectangle>();
            List<Circle> circList = new List<Circle>();

            var rect1 = new Rectangle(2, 2);
            var rect2 = new Rectangle(3, 3);
            var rect3 = new Rectangle(4, 4);
            var rect4 = new Rectangle(5, 5);

            var circ1 = new Circle(2);
            var circ2 = new Circle(3);
            var circ3 = new Circle(4);
            var circ4 = new Circle(5);

            rectList.Add(rect1);
            rectList.Add(rect2);
            rectList.Add(rect3);
            rectList.Add(rect4);

            circList.Add(circ1);
            circList.Add(circ2);
            circList.Add(circ3);
            circList.Add(circ4);

            double scale=7.789;
            
            for (int i = 0; i < rectList.Count ; i++)
            {
                rectList[i].Width = rectList[i].Width * scale;
                rectList[i].Height = rectList[i].Height * scale;
            }
            foreach (var current in circList)
            {
                current.CircleRadius = current.CircleRadius * scale;
            }

            Console.Clear();                                                                //wiem że to
                                                                                            //nie potrzebne
            for (int i = 0; i < rectList.Count; i++)                                        //ale chciałem zapytać czy ma to jakiś sens?
            {
                rectangle.Width = rectList[i].Width;
                rectangle.Height = rectList[i].Height;
                double calculateArea = rectangle.CalculateArea();                           //czy całkiem nie tędy droga?
                Console.WriteLine("Pole prostokąta {0} = {1}", i + 1, calculateArea);
            }
            Console.ReadKey();
        }

    }

//    public class TaskClass13

//    {
//        public Rectangle Test()
//        {
//            var consoleValueReader = new ConsoleValueReader();
//            var rectangle = new Rectangle();

//            rectangle.Width = consoleValueReader.ReadDouble("Wpisz szerokość : ");

//            rectangle.Height = consoleValueReader.ReadDouble("Wpisz wysokość : ");

//            rectangle.Scale(factor: consoleValueReader.ReadDouble("Wpisz Skalę : "));


//            double calculateArea = rectangle.CalculateArea();
//            Console.WriteLine("Pole prostokąta = " + calculateArea);
//            Console.ReadKey();

//            return rectangle;
//        }

//    }
//    class TaskClass14
//    {
//        public Circle Test()
//        {
//            var circle = new Circle();
//            var consoleValueReader = new ConsoleValueReader();

//            circle.CircleRadius = consoleValueReader.ReadDouble("Wpisz promień koła : ");

//            circle.Scale(factor: consoleValueReader.ReadDouble("Wpisz Skalę : "));

//            double circleArea = circle.CircleArea();
//            Console.WriteLine("Pole koła = " + circleArea);
//            Console.ReadKey();
//            return circle;
//        }
//    }
}
