using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reloaded.Tasks.Task22
{
    public class TaskClass22
    {
        public void Test()
        {
            var text = File.ReadAllText("spaceship.txt");
            Console.Write(text);
            Console.ReadKey();
        }
    }
}
