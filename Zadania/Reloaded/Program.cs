using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Tasks.Task0;
using Reloaded.Tasks.Task1;
using Reloaded.Tasks.Task2;
using Reloaded.Tasks.Task3;
using Reloaded.Tasks.Task4;
using Reloaded.Tasks.Task5;
using Reloaded.Tasks.Task6;
using Reloaded.Tasks.Task7;
using Reloaded.Tasks.Task8;
using Reloaded.Tasks.Task9;
using Reloaded.Tasks.Task10;
using Reloaded.Tasks.Task11;
using Reloaded.Tasks.Task12;
using Reloaded.Tasks.Task13;
using Reloaded.Tasks.Task14;
using Reloaded.Tasks;
using Reloaded.Examples;
using Reloaded.Tasks.Task16;
using Reloaded.Tasks.Task16a;
using Reloaded.Tasks.Task16b;
using Reloaded.Tasks.Task16c;
using Reloaded.Tasks.Task16d;
using Reloaded.Tasks.Task16e;
using Reloaded.Tasks.TaskX.Task13;
using Reloaded.Tasks.TaskX.Task16a;
using Reloaded.Tasks.TaskX.Task16b;
using Reloaded.Tasks.TaskX.Task16c;
using Reloaded.Tasks.TaskX.Task16d;
using Reloaded.Tasks.Task16fSandbox;
using System.Threading;
using Reloaded.Tasks.TaskX.TaskAsync;
using Reloaded.Tasks.Task17;
using Reloaded.Tasks.Task18;

// test

namespace Reloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            //new ClassMembersExplanation().PropertyDalszeWyjasnienia();
            //new PersonTester().Test();
            //var testClass16c = new TestClass16c();
            //testClass16c.Test();
            //var test = new TestClass16d();
            //test.Test();
            //var taskSandbox = new TaskClass16fSandbox(new ConsoleCountriesSearchReportWriter());
            //taskSandbox.Test();
            //Console.ReadKey();
            //var taskClass16e = new TaskClass16e();
            //taskClass16e.Test();


            //var ae = new AsyncExample();
            //ae.Working();

            //var tac = new TaskAsyncClass();
            //tac.Test();

            //var task17 = new TaskClass17();
            //task17.Test();

            var task18 = new TaskClass18();
            task18.Test();

        }
    }

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

            Func<string, int, double, string> c = new Func<string, int, double, string>((string p1, int p2, double p3) =>
            {
                return "";
            });

            c = Method2;
            c("", 1, 3.333);
        }

        private string Method1(string p1, int p2, double p3)
        {
            return "";
        }

        private string Method2(string p1, int p2, double p3)
        {
            return "sdfasdfa";
        }

        public void Working()
        {
            var task1 = ShowStringAsync("*", 1000);
            var task2 = ShowStringAsync("#", 500);
            Console.WriteLine("Wduś dowolny przycisk");
            Console.ReadKey();
        }

        public async Task Test()
        {
            await ShowStringAsync("-", 400);
        }

        public async Task ShowStringAsync(string str, int delay)
        {
            await Task.Run(() =>
            {
                ShowString(str, delay);
            });
        }

        public void ShowString(string str, int delay)
        {
            while (true)
            {
                Console.Write(str);
                Thread.Sleep(delay);
            }
        }
    }
}
