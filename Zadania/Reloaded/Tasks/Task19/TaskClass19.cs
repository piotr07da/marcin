using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reloaded.Tasks.Task19
{
    public class TaskClass19
    {
        public void Test()
        {
            DateTime dt = DateTime.Now;

            File.WriteAllText("data&time.txt", dt.ToString("yyyy-MMM-dd") + " patatajnia");

            Console.WriteLine($"{dt}  - zapisano do pliku");
            Console.ReadKey();
        }
    }
}
