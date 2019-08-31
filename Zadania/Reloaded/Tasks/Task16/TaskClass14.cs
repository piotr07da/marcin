using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Tasks.Task14;

namespace Reloaded.Tasks.Task16
{
    class TaskClass14
    {
        public Circle Test()
        {
            var circle = new Circle();
            var consoleValueReader = new ConsoleValueReader();

            circle.CircleRadius = consoleValueReader.ReadDouble("Wpisz promień koła : ");

            circle.Scale(factor: consoleValueReader.ReadDouble("Wpisz Skalę : "));
                        
            double circleArea = circle.CircleArea();
            Console.WriteLine("Pole koła = " + circleArea);
            Console.ReadKey();
            return circle;
        }
    }
}
