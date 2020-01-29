using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task14
{
    public  class Class14
    {
        
        public void Test()
        {
            var circle = new Circle();
            var conValueRead = new ConsoleValueReaderX();

            circle.CircleRadius = conValueRead.ReadDouble("Wpisz promień koła : ");
            circle.CircleRadius = circle.Scale(conValueRead.ReadDouble("Podaj współczynnik skalowania : "));

            Console.WriteLine("Pole koła to : "+ circle.CalculateArea());
            Console.ReadKey();
        }
    }
}
