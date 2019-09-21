using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    public class AsyncExample
    {
        public void NotWorking1()
        {
            while (true)
            {
                Console.Write("*");
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

        public void NotWorking2()
        {
            while (true)
            {
                Console.Write("*");
                Thread.Sleep(1000);
                Console.ReadKey();

            }
        }

        public void Working()
        {
            var task1 = ShowStringAsync("*", 1000); // odpalamy zadanie ale nie robimy await czyli nie czekamy na skończenie zadania - po prostu od razu przechodzimy do kolejnej linijki
            var task2 = ShowStringAsync("#", 500); // to samo co wyżej - bez await czyli nie czekamy, przechodzimy dalej
            Console.WriteLine("Wduś dowolny przycisk");
            Console.ReadKey();
        }

        public async Task Test()
        {
            await ShowStringAsync("-", 400);
            Console.ReadKey();
        }

        public async Task ShowStringAsync(string str, int delay)
        {
            Console.WriteLine();
            Console.WriteLine($"ShowStringAsync({str}, {delay}) - BEGIN");

            // Task.Run to takie magiczne powiedzenie - wykonuje jakieś zadanie z boku - równolegle.
            // No a await oznacza - oczekuj na skończenie tego zadania w ramach tej metody.
            await Task.Run(() =>
            {
                ShowString(str, delay);
            });

            Console.WriteLine();
            Console.WriteLine($"ShowStringAsync({str}, {delay}) - END");
        }

        public void ShowString(string str, int delay)
        {
            for (var i = 0; i < 8; ++i)
            {
                Console.Write(str);
                Thread.Sleep(delay);
            }
        }
    }
}
