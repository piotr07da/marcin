﻿using System;
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

            var task2 = new TaskClass2(); 
            task2.Test();

            var task3 = new TaskClass3(); 
            task3.Test();

            var task4 = new TaskClass4();
            task4.Test();

            var task5 = new TaskClass5();
            task5.Test();
        }
    }

    
}
