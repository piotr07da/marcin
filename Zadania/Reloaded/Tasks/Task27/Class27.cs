using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Reloaded.Tasks.Task27
{
    public class Class27
    {
        public void Test()
        {
            var random = new Random();
            var cVR = new ConsoleValueReader();
            var inC = new InCircle();
            int x;
            int y;
            int pointInTheMiddle=0;
            int allPoint=0;
            
            double randomQuantity = cVR.ReadDouble("Podaj ilość losowań :");
                       
            Console.WriteLine($"Liczba losowań to : { randomQuantity}");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < randomQuantity; i++)
            {
                x = random.Next(-50, 50);
                y = random.Next(-50, 50);
                if(inC.IsInCircle(x, y))
                {
                    pointInTheMiddle++;
                }
                allPoint = i+1;
                Console.Write(4*pointInTheMiddle/allPoint+",");
                Thread.Sleep(200);
            }
            Console.ReadKey();

        }

    }
}
