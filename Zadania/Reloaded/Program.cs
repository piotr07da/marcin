using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Tasks.Task0;
using Reloaded.Tasks.Task1;

// test

namespace Reloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            var task0 = new TaskClass0();
            task0.Test();

            var task1 = new TaskClass1();
            task1.Test();

            var task2 = new Tasks.Task2.TaskClass2(); //Innaczej nie widzi tej klasy
            task2.Test();

            var task3 = new Tasks.Task3.TaskClass3(); // jw
            task3.Test();
        }
    }

    
}
