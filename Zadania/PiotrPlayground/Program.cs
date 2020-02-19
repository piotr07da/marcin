using PiotrPlayground.CronPlayground;
using PiotrPlayground.DatabasePlayground;
using System;

namespace PiotrPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            new DatabasePlaygroundRunner().Run();

            Console.ReadKey();
        }
    }
}
