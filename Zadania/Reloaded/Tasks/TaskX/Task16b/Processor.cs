using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16b
{
    public class Processor
    {
        public Processor(string name, double timing, int numberOfCores)
        {
            Name = name;
            Timing = timing;
            NumberOfCores = numberOfCores;
        }
        public string Name { get; set; }
        public double Timing { get; set; }
        public int NumberOfCores { get; set; }
    }
}
