using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16b
{
    public class TestClass
    {
        public void Test()
        {
            var resolution = new Resolution(2000, 1000);
            var screen = new Screen(false, 12, resolution);
            var ram = new Ram(RamType.DDR3, 8);
            var processor = new Processor("Pentium", 2.7, 2);
            var laptop = new Laptop("Dell", "Latitude", processor, ram, screen);

            var resolution2 = new Resolution(800, 600);
            var screen2 = new Screen(true, 11.6, resolution2);
            var ram2 = new Ram(RamType.DDR2, 2);
            var processor2 = new Processor("Commodore", 0.1, 1);
            var laptop2 = new Laptop("Acer", "Com", processor2, ram2, screen2);
        }
    }
}
