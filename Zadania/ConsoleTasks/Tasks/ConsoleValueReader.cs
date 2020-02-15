using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTasks.Tasks
{
    public class ConsoleValueReader
    {
        public double ReadDouble(string enterValueMessage)
        {
            double value;

            Console.Clear();
            Console.Write($"{enterValueMessage} :");

            for (; ; )
            {
                bool results = double.TryParse(Console.ReadLine(), out value);

                if (results)
                {
                    if (value <= 0)
                    {
                        Console.Clear();
                        Console.Write("Wpisz liczbę większą od zera : ");
                    }
                    else
                    {
                        break;
                    }
                }

                else
                {
                    Console.Clear();
                    Console.Write("Wpisz LICZBĘ : ");
                }

            }
            return value;
        }
    }
}

