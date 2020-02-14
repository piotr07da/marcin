using ConsoleTasks.Tasks.Task30;
using System;

namespace ConsoleTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskRunner = new TaskRunner();
            taskRunner.RunTaskTest(new TaskClass30());
        }
    }

    public class TaskRunner
    {
        public void RunTaskTest(ITask task)
        {
            Console.Clear();
            task.Test();
            Console.ReadKey();
        }
    }
}

