using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16a
{
    public class Book
    {
        
        public Book(string tytul, int rokWydania,AutorKsiazki autorKsiazki, string gatunek, int liczbaStron)
        {
            Tytul = tytul;
            RokWydania = rokWydania;
            Gatunek = gatunek;
            LiczbaStron = liczbaStron;
            AutorKsiazki = autorKsiazki;
        }
        
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public AutorKsiazki AutorKsiazki { get; set; }
        public string Gatunek { get; set; }
        public int LiczbaStron { get; set; }
        private bool _czyWypozyczona;
        public bool CzyWypozyczona { get { return _czyWypozyczona; } }

        public bool Wypozycz()
        {
            if (_czyWypozyczona) { throw new Exception("Kaiążka jest wypożyczona"); }
            else { _czyWypozyczona = true; }
            return _czyWypozyczona;
        }
        public bool Oddaj()
        {
            if (_czyWypozyczona) { _czyWypozyczona = false; }
            else { throw new Exception("Książka jest oddana"); }
            return _czyWypozyczona;
        }
        
    }
}
