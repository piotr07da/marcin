using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reloaded.Examples
{
    public class ClassMembersExplanation
    {
        public void CoToJestTotalDays()
        {
            // Wyjaśniam pytanie dotyczące co to jest TotalDays

            DateTime urodzinyMojejMamy = new DateTime(1958, 1, 16);
            DateTime dzisiaj = DateTime.Now;

            TimeSpan okresZycia = dzisiaj - urodzinyMojejMamy; // Typ DateTime jest tak zrobiony, że ma nadpisany operator minus (-) w taki sposób, że wynik takiego odejmowania dwóch DateTime'ów zwraca obiekt typu TimeSpan (czyli zakres czasu) ...

            // ... no i tak się składa, że typ TimeSpan ma takie property jak TotalDays czyli liczba dni w tym TimeSpanie

            double dniZycia = okresZycia.TotalDays;

            // ... a żeby to przerobić na lata to dzielę przez 365:

            int wiekLiczonyWLatach = (int)dniZycia / 365; // to oczywiście jest niedokładne bo nie uwzględnia lat przestępnych, ale w przybliżeniu działa
        }


        public void PropertyDalszeWyjasnienia()
        {
            var k1 = new Kolo()
            {
                Felga = UtworzNowaFelgeSparco_Z_CzujnikiemCisnienia(),
                Opona = new Opona(TypOpony.Zimowa),
            };
            var k2 = new Kolo()
            {
                Felga = UtworzNowaFelgeSparco_Z_CzujnikiemCisnienia(),
                Opona = new Opona(TypOpony.Zimowa),
            };
            var k3 = new Kolo()
            {
                Felga = UtworzNowaFelgeSparco_BEZ_CzujnikaCisnienia(),
                Opona = new Opona(TypOpony.Zimowa),
            };
            var k4 = new Kolo()
            {
                Felga = UtworzNowaFelgeSparco_BEZ_CzujnikaCisnienia(),
                Opona = new Opona(TypOpony.Zimowa),
            };

            var fel1 = new Felga();
            fel1.Marka = "Ronal";

            var mmmm = fel1.Marka;

            var fel2 = new Felga("Ronal");

            var samochod = new Samochod();

            samochod.KoloPrzednieLewe = k1;
            samochod.KoloPrzedniePrawe = k2;
            samochod.KoloTylneLewe = k3;
            samochod.KoloTylnePrawe = k4;

            // I teraz możemy się odwoływać do tych zagnieżdżonych property:

            bool czyCzujnikWPrawymPrzednimKoleJestSprawny = samochod.KoloPrzedniePrawe.Felga.CzujnikCisnienia.CzyJestSprawny;
            bool czySamochodMaZalozoneTylneLeweKolo = samochod.KoloTylneLewe != null;
            string markaFelgiNaPrawymTylnymKole = samochod.KoloTylnePrawe.Felga.Marka;
            TypOpony typOponyNaLewymPrzednimKole = samochod.KoloPrzednieLewe.Opona.Typ;
            string typOponyNaLPJakoStringWielkimiLiterami = samochod.KoloPrzednieLewe.Opona.Typ.ToString().ToUpper();
            int dlugoscNazwyTypuOponyNaLP = samochod.KoloPrzednieLewe.Opona.Typ.ToString().Length;

            // Czyli podsumowując powyższe - każde property zwraca obiekt jakiegoś typu - nie ważne czy to będzie obiekt Twojego typu/klasy czy to będzie obiekt jakiejś klasy od Microsoftu (np. TimeSpan).
            // I ten zwracany typ ma swoje property, które zwraca obiekt innego typu, który znowu ma swoje property i tak dalej, i tak dalej



            // Zerknij poniżej jak te klasy są popisane. Jest tam parę ciekawostek. Np. enum, albo konstruktory z parametrami, albo konstruktor bez parametrów, który coś tam inicjalizuje.
        }

        private Felga UtworzNowaFelgeSparco_Z_CzujnikiemCisnienia()
        {
            return UtworzNowaFelgeSparco(new CzujnikCisnienia());
        }

        private Felga UtworzNowaFelgeSparco_BEZ_CzujnikaCisnienia()
        {
            return UtworzNowaFelgeSparco(null);
        }

        private Felga UtworzNowaFelgeSparco(CzujnikCisnienia czujnikCisnienia)
        {
            var f = new Felga("Sparco")
            {
                CzujnikCisnienia = czujnikCisnienia,
            };

            return f;
        }
    }

    public class Samochod
    {
        public Kolo KoloPrzednieLewe { get; set; }
        public Kolo KoloPrzedniePrawe { get; set; }
        public Kolo KoloTylneLewe { get; set; }
        public Kolo KoloTylnePrawe { get; set; }
    }

    public class Kolo
    {
        public Felga Felga { get; set; }
        public Opona Opona { get; set; }
    }

    public class Opona
    {
        public Opona(TypOpony t)
        {
            Typ = t;
        }

        public TypOpony Typ { get; set; }
    }

    public class Felga
    {
        public Felga()
        {
            Marka = "marka nieznana";
        }

        public Felga(string m)
        {
            Marka = m;
        }

        public string Marka { get; set; }

        public CzujnikCisnienia CzujnikCisnienia { get; set; }
    }

    public class CzujnikCisnienia
    {
        public CzujnikCisnienia()
        {
            CzyJestSprawny = true; // domyślnie każdy nowy przyjmujemy, że będzie zainicjalizowany jako sprawny.
        }


        public bool CzyJestSprawny { get; set; }
    }

    public enum TypOpony
    {
        Letnia,
        Zimowa,
        Caloroczna,
    }
}
