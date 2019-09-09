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
            var rectangleX = new RectangleX();
            var consoleWalueReaderX = new ConsoleValueReaderX();
            rectangleX.Width = consoleWalueReaderX.ReadDouble("Wpisz szerokość : ");
            rectangleX.Height = consoleWalueReaderX.ReadDouble("Wpisz wysokość : ");
            rectangleX.Scale(consoleWalueReaderX.ReadDouble("Wpisz skale : "));
            rectangleX.CalculateArea();
            double calculateArea = rectangleX.CalculateArea();
            Console.WriteLine("Pole prostokąta to : " + calculateArea);
            Console.ReadKey();
                        
        }
    }
}
