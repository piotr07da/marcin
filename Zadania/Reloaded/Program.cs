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
using Reloaded.Tasks.Task19;
using Reloaded.Tasks.Task20;
using System.Diagnostics;
using Reloaded.Tasks.Task21;


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
            //var taskSandbox = new TaskClass16fSandbox(1, 2, 3, "Państwa", new FileCountriesSearchReportWriter());
            //taskSandbox.Test();
            //Console.ReadKey();
            //var taskClass16e = new TaskClass16e();
            //taskClass16e.Test();


            //var ae = new AsyncExample();
            //ae.Test();

            //var tac = new TaskAsyncClass();
            //tac.Test();

            //var task17 = new TaskClass17();
            //task17.Test();

            //var task18 = new TaskClass18();
            //task18.Test();

            //var task19 = new TaskClass19();
            //task19.Test();

            //var task20 = new TaskClass20();
            //task20.Test();

            //var asy2 = new AsyncExample2();
            //var t = asy2.Test();
            //t.Wait();

            //var asex = new AsyncExplanation();
            //asex.Test();

            //var task21 = new TaskClass21();
            //task21.Test();






            var taskAsyncClass = new TaskAsyncClass();
            taskAsyncClass.TestWithCancellationToken();

        }
    }

    
}
