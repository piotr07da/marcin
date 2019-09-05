using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16b
{
    public class Ram
    {
        public Ram(TypRamu typRamu, int rozmiar)
        {
            Typ = typRamu;
            Rozmiar = rozmiar;
        }
        public TypRamu Typ { get; set; }
        public int Rozmiar { get; set; }
    }
    public enum TypRamu
    {
        DDR2,
        DDR3,
        DDR4,
    }
}
