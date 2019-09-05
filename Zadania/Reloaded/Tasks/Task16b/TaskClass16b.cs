using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16b
{
    public class TaskClass16b
    {
        public void Test()
        {
            var procesor = new Procesor("i5-3340m", 2.7, 2);
            var typRamu = TypRamu.DDR3;
            var ram = new Ram(typRamu, 8);
            var rozdzielczosc = new Rozdzielczosc(1920, 1080);
            var ekran = new Ekran(12, false, rozdzielczosc);
            var laptop = new Laptop("Dell", "Latitude/E6230", procesor, ram, ekran);

            var procesor2 = new Procesor("i1-1120", 1, 1);
            var typRamu2 = TypRamu.DDR2;
            var ram2 = new Ram(typRamu2, 2);
            var rozdzielczosc2 = new Rozdzielczosc(800, 600);
            var ekran2 = new Ekran(11.6, true, rozdzielczosc2);
            var laptop2 = new Laptop("Acer", "Aspire V5", procesor2, ram2, ekran2);
        }
    }
}
   
