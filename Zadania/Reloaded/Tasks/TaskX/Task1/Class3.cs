using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Examples;

namespace Reloaded.Tasks.TaskX.Task1
{
    public class Class3
    {
        //public Class3(Person magda, Person marcin, Person piotr)
        //{

        //}
        public void Test()
        {
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

            GenericSortDelegate<Person> sort; // to będzie wskaźnik na metodę sortującą osoby czyli po prostu zamiast T podstawiliśmy Person

            sort = SortPeople;

            //var person = new Person();
            var people = new List<Person>()
            {
                // i tu jacyś ludkowie
               marcin,magda,piotr
            };
            var sortedPeople = sort(people);
        }
        private List<Person> SortPeople(List<Person> notSorted)
        {
            List<Person> result;

            // UWAGA: Tutaj od razu zwróć uwagę na to jak sprytnie jest użyty delegat jako parametr metody OrderBy - tym parametrem jest delegat, który na podstawie elementu listy (w naszym przypadku Person) ma zwrócić wartość na podstawie, której sortujemy - ja zdedycowałem, że będzie to data urodzenia.
            result = notSorted.OrderBy(p => p.DataUrodzenia).ToList();

            // dało by się to też zapisać tak:
            result = notSorted.OrderBy(p =>
            {
                return p.DataUrodzenia;
            }).ToList();

            // albo dało by się zapisać tak (bez użycia metody anonimowej tylko z użycie metody normalnej):

            result = notSorted.OrderBy(ImieSelector).ToList();

            // albo to samo tylko trochę bardziej rozpisane:

            Func<Person, DateTime> orderByKeySelector = DataUrodzeniaSelector;
            result = notSorted.OrderBy(orderByKeySelector).ToList();

            // -----------

            return result;
        }
        private string ImieSelector(Person person)
        {
            return person.Imie;
        }
        private DateTime DataUrodzeniaSelector(Person person)
        {
            return person.DataUrodzenia;
        }
    }
}
