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

            double value;

            Console.Clear();

            Console.Write("Wpisz promień koła : ");
           
            for(; ; )
            {
                bool results = double.TryParse(Console.ReadLine(), out value);
                if (results)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Wpisz liczbę większą od 0 : ");
                    }
                    else break;
                }
                else
                {
                    Console.WriteLine("Wpisz LICZBĘ : ");
                }
            }
            circle.CircleRadius = value;
            double circleArea = circle.CircleArea();
            Console.WriteLine("Pole koła = " + circleArea);
            Console.ReadKey();
            return circle;
        }
    }
}
