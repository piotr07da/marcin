using System.Text.RegularExpressions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    public class PersonTester
    {
        public void Test()
        {
            var banan = new Jedzenie("Banan żółty", 100);
            var bulka = new Jedzenie("Bułka poznańska", 200);
            var tikTak = new Jedzenie("TikTak miętowy", 2);

            var persons = new List<Person>();

            var marcin = new Person();
            marcin.Imie = "Marcin";
            marcin.Nazwisko = "Bejger";
            marcin.DataUrodzenia = new DateTime(1982, 2, 11);
            marcin.Plec = Plec.Mezczyzna;

            var magda = new Person();
            magda.Imie = "Magda";
            magda.Nazwisko = "Bejger";
            magda.DataUrodzenia = new DateTime(1990, 11, 9);
            magda.Plec = Plec.Kobieta;

            var piotr = new Person();
            piotr.Imie = "Piotr";
            piotr.Nazwisko = "Bejger";
            piotr.DataUrodzenia = new DateTime(1985, 12, 12);
            piotr.Plec = Plec.Mezczyzna;
            //piotr._poziomGlodu = 9999999;

            piotr.Nakarm(bulka);

            bulka.CzyJedzenieJestZgnite = true;

            piotr.Nakarm(bulka);
            piotr.Nakarm(tikTak);

            var piotrPoziomGlodu = piotr.PoziomGlodu;

            persons.Add(marcin);


            Person p;
            int x;

            var dt = new DateTime(1982, 2, 11);
        }
    }


    public class Person
    {
        private string _imie;
        public string Imie
        {
            get { return _imie; }
            set
            {
                _nazwisko = WalidujImieLubNazwisko("imię", value);
            }
        }

        private string _nazwisko;
        public string Nazwisko
        {
            get { return _nazwisko; }
            set
            {
                _nazwisko = WalidujImieLubNazwisko("nazwisko", value);
            }
        }

        private string WalidujImieLubNazwisko(string nazwaCechy, string wartoscCechy)
        {
            if (CzyImieAlboNazwiskoJestOkej(wartoscCechy))
            {
                return wartoscCechy;
            }
            else
            {
                throw new Exception($"Podałeś niewłaściwe {nazwaCechy}: {wartoscCechy}");
            }
        }

        public DateTime DataUrodzenia { get; set; }
        public Plec Plec { get; set; }

        private int _poziomGlodu;
        public int PoziomGlodu
        {
            get { return _poziomGlodu; }
        }

        public void Nakarm(Jedzenie j)
        {
            if (j.CzyJedzenieJestZgnite)
            {
                throw new Exception($"Ty debilu. Chcesz mnie nakarmić zgnitym: {j.Nazwa}?");
            }

            _poziomGlodu -= j.Kcal / 100;
            if (_poziomGlodu < 0)
            {
                _poziomGlodu = 0;
            }
        }

        public void Biegaj(int ileKm)
        {
            _poziomGlodu += ileKm;
            if (_poziomGlodu > 10)
            {
                throw new Exception("Umarłem");
            }
        }



        private bool CzyImieAlboNazwiskoJestOkej(string imieAlboNazwisko)
        {
            var rx = new Regex("^[a-zA-Z]+$"); // to sprawdza czy są wyłącznie znaki a-z lub A-Z w liczbie od 1 do nieskończoności
            return rx.IsMatch(imieAlboNazwisko);
        }
    }

    public enum Plec
    {
        Kobieta,
        Mezczyzna,
    }
    public class Jedzenie
    {
        public Jedzenie(string nazwa, int ileKilokalorii)
        {
            Nazwa = nazwa;
            Kcal = ileKilokalorii;
        }

        public string Nazwa { get; private set; }
        public int Kcal { get; private set; }
        public bool CzyJedzenieJestZgnite { get; set; }
    }

}
