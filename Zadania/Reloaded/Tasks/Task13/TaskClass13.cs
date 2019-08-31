using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Reloaded.Tasks.Task13
{
    public class TaskClass13

    {
        public Rectangle Test()
        {
            var consoleValueReader = new ConsoleValueReader();
            var rectangle = new Rectangle();
                                   
            rectangle.Width = consoleValueReader.ReadDouble("Wpisz szerokość : ");
            
            rectangle.Height = consoleValueReader.ReadDouble("Wpisz wysokość : ");

            rectangle.Scale(factor:consoleValueReader.ReadDouble("Wpisz Skalę : "));            
               

            double calculateArea = rectangle.CalculateArea();
            Console.WriteLine("Pole prostokąta = " + calculateArea);
            Console.ReadKey();
            
            return rectangle;
        }

    }
}
