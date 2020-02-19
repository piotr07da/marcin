using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PiotrPlayground.CronPlayground
{
    public class CronPlaygroundRunner
    {
        public void Run()
        {
            var entries = new[]
            {
                new SchedulerEntry(1500, "msg1500"),
                new SchedulerEntry(500, "msg500"),
                new SchedulerEntry(2500, "msg2500"),
                new SchedulerEntry(4500, "msg4500"),
            };

            Task.Run(() =>
            {
                while (true)
                {

                }
            });
        }

        private async Task LoopEntry(SchedulerEntry entry)
        {
            while (true)
            {
                await Task.Delay(entry.Interval);
                Console.WriteLine(entry.Message);
            }
        }
    }

    public class SchedulerEntry
    {
        public SchedulerEntry(int interval, string message)
        {
            Interval = interval;
            Message = message;
        }

        public int Interval { get; set; }
        public string Message { get; set; }
    }
}
