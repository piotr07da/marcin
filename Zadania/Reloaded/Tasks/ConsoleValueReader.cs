using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks
{
    public class ConsoleValueReader
    {
        public double ReadDouble(string enterValueMessage)

        {
            Console.Clear();
            double value ;
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
