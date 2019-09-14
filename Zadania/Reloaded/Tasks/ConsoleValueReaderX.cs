using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks
{
    public class ConsoleValueReaderX
    {
        public double ReadDouble(string enterValueMessage)
        {
            double value;
            Console.Clear();
            Console.Write(enterValueMessage);
            for (; ; )
            {
                bool results = double.TryParse(Console.ReadLine(), out value);
                if (results)
                {
                    if (value <= 0)
                    {
                        Console.Write("Wpisz wartość większą od 0 : ");
                    }
                    else
                    {
                        break;                       
                    }
                }
                else
                {
                    Console.Write("Wpisz LICZBE : ");
                }
            }
            return value;
        }
    }
}
