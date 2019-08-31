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
            var rect1 = new Rectangle();
            var rect2 = new Rectangle();
            var rect3 = new Rectangle();
            var rect4 = new Rectangle();

            var circ1 = new Circle();
            var circ2 = new Circle();
            var circ3 = new Circle();
            var circ4 = new Circle();
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
