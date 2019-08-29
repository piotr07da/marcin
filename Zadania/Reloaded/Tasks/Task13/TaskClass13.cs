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
            var rectangle = new Rectangle();
            Console.Clear();

            rectangle.Width = ReadDoubleFromConsole("Wpisz szerokość : ");

            rectangle.Height = ReadDoubleFromConsole("Wpisz wysokość : ");

            double calculateArea = rectangle.CalculateArea();
            Console.WriteLine("Pole prostokąta = " + calculateArea);
            Console.ReadKey();

            
            return rectangle;
        }
        double ReadDoubleFromConsole(string enterValueMessage)

        {
            double value = 0;
            Console.Write(enterValueMessage);
            for (; ; )
            {
                bool results = double.TryParse(Console.ReadLine(), out value);

                if (results)
                {
                    if (value <= 0)
                    {
                        Console.Write("Wpisz liczbę większą od 0 : ");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write("Wpisz LICZBĘ większą od 0 : ");
                }
            }
            return value;
        }
    }
}
