using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16b
{
    public class Procesor
    {
        public Procesor(string nazwa, double taktowanie, int liczbaRdzeni)
        {
            Nazwa = nazwa;
            Taktowanie = taktowanie;
            LiczbaRdzeni = liczbaRdzeni;
        }
        public string Nazwa { get; set; }
        public double Taktowanie { get; set; }
        public int LiczbaRdzeni { get; set; }
    }
}
