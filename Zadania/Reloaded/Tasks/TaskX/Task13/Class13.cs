using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task13
{
    public class Class13
    {
        public void Test()
        {
            var consoleValueReaderX = new ConsoleValueReaderX();
            var rec = new Rectangle();

            rec.Height = consoleValueReaderX.ReadDouble("Podaj Wysokość Prostokąta :");
            rec.Width = consoleValueReaderX.ReadDouble("Podaj Szerokość Prostokąta :");

            double calculateArea = rec.CalculateArea();
            Console.WriteLine("Pole prostokąta to : "+calculateArea);

            Console.ReadKey();
        }
    }
}
