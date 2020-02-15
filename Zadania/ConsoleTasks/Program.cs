using ConsoleTasks.Examples;
using ConsoleTasks.Tasks.Task30;
using ConsoleTasks.Tasks.Task31;
using System;

namespace ConsoleTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var taskRunner = new TaskRunner();
            //taskRunner.RunTaskTest(new SzklankaTesty());
            var task31 = new TaskClass31();
            task31.Test();
        }
    }

    //public class TaskRunner
    //{
    //    public void RunTaskTest(ITask task)
    //    {
    //        Console.Clear();
    //        task.Test();
    //        Console.ReadKey();
    //    }
    //}
}

