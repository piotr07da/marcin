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
            var autorKsiazki = new AutorKsiazki("Mirosław","Kardaś");
            var ksiazka = new Ksiazka("Język C",autorKsiazki, 2013, "Kurs", 519);
           
            var autorKsiazki2 = new AutorKsiazki("Henryk", "Prochniewicz");
            var ksiazka2 = new Ksiazka("Kierowca Doskonały", autorKsiazki2, 2015, "Podręcznik", 369);

            var autorKsiazki3 = new AutorKsiazki("Jarosław", "Psikuta");
            var ksiazka3 = new Ksiazka("Patatajnia", autorKsiazki3, 2019, "Romans", 14);

            ksiazka.Wypozycz();
            ksiazka2.Wypozycz();
            ksiazka3.Wypozycz();
            ksiazka.Oddaj();
            ksiazka2.Oddaj();
            //ksiazka2.Oddaj();
            //ksiazka3.Wypozycz();
        }


    }
    class Ksiazka
    {
        public Ksiazka(string Tytul, AutorKsiazki autorKsiazki, int RokWydania, string Gatunek, int LiczbaStron)
        {
            this.Tytul = Tytul;
            AutorKsiazki = autorKsiazki;
            this.RokWydania = RokWydania;
            this.Gatunek = Gatunek;
            this.LiczbaStron = LiczbaStron;
        }

        
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public string Gatunek { get; set; }
        public AutorKsiazki AutorKsiazki { get; set; }
        public int LiczbaStron { get; set; }
        private bool _czyWypozyczona ;                 //niby w property chodzi o to żeby z tego pola nie korzystać? czy chodzi o to że i tak korzystamy z metod Wypozycz Oddaj żeby się do niego dobrać i domniemanemu interfejsowi nie będzie to przeszkadzać?
        public bool CzyWypozyczona { get { return _czyWypozyczona; } }

        public void Wypozycz()
        {
            if (!(_czyWypozyczona))                   //czy w C# można tak robić?
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
        public AutorKsiazki(string Imie, string Nazwisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
        }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

    }
}
