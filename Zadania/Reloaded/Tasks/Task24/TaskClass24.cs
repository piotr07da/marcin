using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Reloaded.Tasks.Task24
{
    public class TaskClass24
    {
        private const int x = 100;
        private const int y = 100;
        private const int flake = 10;

        public void Test()
        {
            var wind = new Snow();
            var drav = new Draving();
            var random = new Random();
            int width = random.Next(400, 600);
            int height = random.Next(200, 300);
            int space = flake * 3;
            int quantity = width / space;
            int quantity2 = height / space;
            int firstspace = (space) / 2;
            var snow = new Snow(random);


            drav.Rect(width, height, x, y);

            Snow[,] flakes = new Snow[quantity2, quantity];

            List<Snow> fList = new List<Snow>();

            for (int a = 0; a < quantity2; a++)
            {


                for (int i = 0; i < quantity; i++)
                {
                    flakes[a, i] = new Snow();
                    snow.Start(flakes[a, i], firstspace, space, flake, i, x, y, a);
                    fList.Add(flakes[a, i]);
                }
            }

            var task = Flurry(quantity, quantity2, snow, flakes, width, height, wind);
            for (; ; )
            {
                if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                    wind.Wind += 3;
                    if (wind.Wind > 9) { wind.Wind = 9; }
                }
                if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
                {
                    wind.Wind -= 3;
                    if (wind.Wind < -9) { wind.Wind = -9; }
                }
            }

        }
        public async Task Flurry(int quantity, int quantity2, Snow snow, Snow[,] flakes, int width, int height, Snow wind)
        {
            await Task.Run(() =>
            {
                for (; ; )
                {
                    for (int a = 0; a < quantity2; a++)
                    {


                        //Thread.Sleep(2);
                        for (int i = 0; i < quantity; i++)
                        {
                            snow.SMove(flakes[a, i], flake, width, height, x, y, wind);
                        }
                    }
                }
            }
            );
        }
    }
}
