using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16b
{
    public class Laptop
    {
        public Laptop(string firma, string model, Procesor procesor, Ram ram, Ekran ekran)
        {
            Firma = firma;
            Model = model;
            Procesor = procesor;
            Ram = ram;
            Ekran = ekran;
        }
        public string Firma { get; set; }
        public string Model { get; set; }
        public Procesor Procesor { get; set; }
        public Ram Ram { get; set; }
        public Ekran Ekran { get; set; }
    }
}
