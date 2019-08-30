using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task14
{
    class TaskClass14
    {
        public Circle Test()
        {
            var circle = new Circle();
            var consoleValueReader = new ConsoleValueReader();

            circle.CircleRadius = consoleValueReader.ReadDouble("Wpisz promień koła : ");
                        
            double circleArea = circle.CircleArea();
            Console.WriteLine("Pole koła = " + circleArea);
            Console.ReadKey();
            return circle;
        }
    }
}
