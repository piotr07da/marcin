using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Reloaded.Tasks.TaskX.TaskAsync
{
    public class TaskAsyncClass
    {
        public string Name { get; set; }

        public void Test()
        {
            Console.WriteLine("Wpisz imię masz na to 10 sekund.");
            var task = Waiting();
            Name = Console.ReadLine();   // czy jest możliwość odwołania ReadLine jeżeli nie zdążysz wpisać?
           

            Console.ReadKey();
        }

        public void TestWithCancellationToken()
        {
            var cts = new CancellationTokenSource();
            var ct = cts.Token;

            Console.WriteLine("Wpisz imię masz na to 10 sekund.");
            var task = WaitingWithCancellationToken(ct);
            Name = Console.ReadLine();   // czy jest możliwość odwołania ReadLine jeżeli nie zdążysz wpisać?

            cts.Cancel();

            Console.ReadKey();
        }

        public async Task Waiting()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(10000);                //czy jest jakiś sposób żeby wyłączyć ten wątek zanim się skończy?
                if (string.IsNullOrEmpty(Name))
                    Console.WriteLine("Nie zdążyłeś");
                else
                {
                    Console.WriteLine("Imię to : " + Name);
                }
            });
        }




        public async Task WaitingWithCancellationToken(CancellationToken ct)
        {
            Action action = () =>
            {

                ct.WaitHandle.WaitOne(10000);

                if (string.IsNullOrEmpty(Name))
                    Console.WriteLine("Nie zdążyłeś");
                else
                {
                    Console.WriteLine("Imię to : " + Name);
                }
            };

            await Task.Run(action, ct);
        }
    }
}
