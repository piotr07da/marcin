using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16a
{
    class TaskClass16a
    {
        public void Test()
        {
            var ksiazka = new Ksiazka();
            var autorKsiazki = new AutorKsiazki();
            autorKsiazki.Imie = "Mirosław";
            autorKsiazki.Nazwisko = "Kardaś";
            ksiazka.AutorKsiazki = autorKsiazki;
            ksiazka.Tytul = "Język C";
            ksiazka.RokWydania = 2013;
            ksiazka.Gatunek = "Kurs";
            ksiazka.LiczbaStron = 519;

            var ksiazka2 = new Ksiazka();
            var autorKsiazki2 = new AutorKsiazki();
            ksiazka2.AutorKsiazki = autorKsiazki2;
            autorKsiazki2.Imie = "Henryk";
            autorKsiazki2.Nazwisko = "Prochniewicz";
            ksiazka2.Tytul = "Kierowca Doskonały";
            ksiazka2.RokWydania = 2015;
            ksiazka2.Gatunek = "Podręcznik";
            ksiazka2.LiczbaStron = 369;

            var ksiazka3 = new Ksiazka();
            var autorKsiazki3 = new AutorKsiazki();
            ksiazka3.AutorKsiazki = autorKsiazki3;
            autorKsiazki3.Imie = "Jarosław";
            autorKsiazki3.Nazwisko = "Psikuta";
            ksiazka3.Tytul = "Patatajnia";
            ksiazka3.RokWydania = 2019;
            ksiazka3.Gatunek = "Romans";
            ksiazka3.LiczbaStron = 14;

            ksiazka.Wypozycz();
            ksiazka2.Wypozycz();
            ksiazka3.Wypozycz();
            ksiazka.Oddaj();
            ksiazka2.Oddaj();
            //ksiazka2.Oddaj();
            ksiazka3.Wypozycz();
        }
        
        
    }
    class Ksiazka
    {
        
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public string Gatunek { get; set; }
        public AutorKsiazki AutorKsiazki { get; set; }
        public int LiczbaStron { get; set; }
        private bool _czyWypozyczona ;
        public bool CzyWypozyczona { get { return _czyWypozyczona; } }

        public void Wypozycz()
        {
            if (!(_czyWypozyczona))
            {
                _czyWypozyczona = true;
            }
            else
            {
                throw new Exception("Książka wypozyczona");
            }
        }
        public void Oddaj()
        {
            if (_czyWypozyczona)
            {
                _czyWypozyczona = false;
            }
            else
            {
                throw new Exception("Książka oddana");
            }
        }
    }
    class AutorKsiazki
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

    }
}
