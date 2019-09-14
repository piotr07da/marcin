using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16b
{
    public class Laptop
    {
        public Laptop(string firm, string model, Processor processor,Ram ram, Screen screen)
        {
            Firm = firm;
            Model = model;
            Processor = processor;
            Ram = ram;
            Screen = screen;
        }
        public string Firm { get; set; }
        public string Model { get; set; }
        public Processor Processor { get; set; }
        public Ram Ram { get; set; }
        public Screen Screen { get; set; }
    }
}
