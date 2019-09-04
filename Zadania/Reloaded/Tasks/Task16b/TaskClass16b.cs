using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16b
{
    class TaskClass16b
    {
        public void Test()
        {
            var procesor = new Procesor("i5-3340m", "2,7 GHz", 2);
            var typRamu = TypRamu.DDR3;
            var ram = new Ram(typRamu, "8 GB");
            var rozdzielczosc = new Rozdzielczosc(1920,1080);
            var ekran = new Ekran("12' ", false, rozdzielczosc);
            var laptop = new Laptop("Dell", "Latitude/E6230", procesor, ram, ekran);

            var procesor2 = new Procesor("i1-1120", "1 GHz", 1);
            var typRamu2 = TypRamu.DDR2;
            var ram2 = new Ram(typRamu2, "2 GB");
            var rozdzielczosc2 = new Rozdzielczosc(800, 600);
            var ekran2 = new Ekran("11,6' ", true, rozdzielczosc2);
            var laptop2 = new Laptop("Acer", "Aspire V5", procesor2, ram2, ekran2);
        }
    }
    class Laptop
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
    class Procesor
    {
        public Procesor(string nazwa, string taktowanie, int liczbaRdzeni)
        {
            Nazwa = nazwa;
            Taktowanie = taktowanie;
            LiczbaRdzeni = liczbaRdzeni;
        }
        public string Nazwa { get; set; }
        public string Taktowanie { get; set; }
        public int LiczbaRdzeni { get; set; }
    }
    class Ram
    {
        public Ram(TypRamu typRamu,string rozmiar)
        {
            Typ = typRamu;
            Rozmiar = rozmiar;
        }
        public TypRamu Typ { get; set; }
        public string Rozmiar { get; set; }
    }
    class Ekran
    {
        public Ekran(string przekatna, bool czyPolysk, Rozdzielczosc rozdzielczosc)
        {
            Przekatna = przekatna;
            Rozdzielczosc = rozdzielczosc;
            CzyPolysk = czyPolysk;
        }
        public string Przekatna { get; set; }
        public bool CzyPolysk { get; set; }
        public Rozdzielczosc Rozdzielczosc { get; set; }
    }
    public enum TypRamu
    {
        DDR2,
        DDR3,
        DDR4,
    }
    class Rozdzielczosc
    {
        public Rozdzielczosc(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; set; }
        public int Height { get; set; }
    }

}
