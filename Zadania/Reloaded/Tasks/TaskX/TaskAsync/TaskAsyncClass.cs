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


    }
}
