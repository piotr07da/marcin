using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reloaded.Tasks.Task13
{
    public class TaskClass13

    {
        internal Rectangle Test()
        {
            var rectangle = new Rectangle();
            Console.Clear();
            Console.Write("Wpisz szerokość : ");
            for (; ; )
            {
                bool results = double.TryParse(Console.ReadLine(), out rectangle.width);

                if (results)
                {
                    if (rectangle.width <= 0)
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
            Console.Write("Wpisz wysokość : ");
            for(; ; )
            {
                bool results = double.TryParse(Console.ReadLine(), out rectangle.height);
                if (results)
                {
                    if(rectangle.height <= 0)
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
            double calculateArea = rectangle.CalculateArea();         //tu coś napewno
            Console.WriteLine("Pole prostokąta = "+calculateArea);    //napitoliłem
            Console.ReadKey();
            return rectangle;
           
        }
    }
}
