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
            Console.Clear();
            double value;
          
            for (; ; )
            {
                Console.WriteLine(enterValueMessage);
                bool results = double.TryParse(Console.ReadLine(), out value);

                if (results)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Wpisz liczbę większą od zera:");
                    }
                    else break;
                }
                else
                {
                    Console.WriteLine("Wpisz LICZBę większą od zera:");
                }
            }
            return value;
        }
    }
}
