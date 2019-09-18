using System;
using System.Collections.Generic;
using System.Linq;

namespace Reloaded.Examples
{
    public class DelegatesExplanation
    {
        // -------------------------------------------

        public void Test_StringModifierDelegate()
        {
            // Tutaj pokazuję przykład przypisania metody do zmiennej typu delegat  (uwaga - tutaj przypisuję po prostu nazwę metody, a nie jej wywołanie czyli nie podaję nawiasów okrągłych tak jakbym wywoływał metodę bo nie chcę przypisywać wyniku wywołania tylko samą metodę)...
            // chociaż to mogło by mieć sens gdyby moja metoda zwracała metodę bo to też jest możliwe, ale o tym dalej ;)

            StringModifierDelegate del = ModifyString1;
            del("Test A");

            del = ModifyString2;
            del("Test B");

            // a tutaj to samo tylko zamiast przypisywać ModifyString1 albo ModifyString2 to przypisuję metodę anonimową zwaną inaczej lambdą (nie posiadającą nazwy i utworzoną bezpośrednio w metodzie Test_StringModifierDelegate w chwili przypisania)
            // czyli to co jest poniżej to jest metoda, która ma stringowy parametr val i zwraca string'a więc jak najbardziej pasuje do naszego delegata StringModifierDelegate
            del = val =>
            {
                return "*" + val + "*";
            };
        }

        private string ModifyString1(string value)
        {
            return value.ToUpper();
        }

        private string ModifyString2(string value)
        {
            return value.ToLower();
        }

        // -------------------------------------------

        public void Test_DoSomethingDelegate()
        {
            // To właściwie podobnie jak wyżej w Test_StringModifierDelegate.

            DoSomethingDelegate del = null;

            del = DoSmth1;
            del();

            del = DoSmth2;
            del();

            del = () => { Console.WriteLine("333"); };
        }

        private void DoSmth1()
        {
            Console.WriteLine("111");
        }

        private void DoSmth2()
        {
            Console.WriteLine("222");
        }

        // -------------------------------------------

        public void Test_SortDelegate()
        {
            GenericSortDelegate<Person> sort; // to będzie wskaźnik na metodę sortującą osoby czyli po prostu zamiast T podstawiliśmy Person

            sort = SortPeople;

            var people = new List<Person>()
            {
                // i tu jacyś ludkowie
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

            result = notSorted.OrderBy(DataUrodzeniaSelector).ToList();

            // albo to samo tylko trochę bardziej rozpisane:

            Func<Person, DateTime> orderByKeySelector = DataUrodzeniaSelector;
            result = notSorted.OrderBy(orderByKeySelector).ToList();

            // -----------

            return result;
        }

        private DateTime DataUrodzeniaSelector(Person person)
        {
            return person.DataUrodzenia;
        }

        // -------------------------------------------

        public void Test_Func()
        {
            // Tutaj przykład z moim funcem
            PiotrFunc<int, string, DateTime, double> del1 = (number, someString, someDate) => .333 * (number + someString.Length + someDate.Year);

            // Tutaj to samo tylko trochę bardziej rozpisane:
            PiotrFunc<int, string, DateTime, double> del2 = (number, someString, someDate) =>
            {
                return .333 * (number + someString.Length + someDate.Year);
            };

            // Da się to samo zapisać też tak (czyli do konstruktora delegatu jest podana labmda (metoda anonimowa) odpowiadająca temu delegatowi):
            var del3 = new PiotrFunc<int, string, DateTime, double>((number, someString, someDate) =>
            {
                return .333 * (number + someString.Length + someDate.Year);
            });

            // No i identycznie się sprawi gotowiec w postaci Func albo Action

            Func<int, int, int> sum = (a, b) => a + b;

            Action<int, string> consoleWriter = (count, str) =>
            {
                for (var i = 0; i < count; ++i)
                {
                    Console.WriteLine(str);
                }
            };

            // No i nie pozostaje nic innego niż sobie te delegaty powywoływać:

            var x1 = del1(10, "Piotr", DateTime.Now);
            var x2 = del2(10, "Piotr", new DateTime(2019, 09, 18));
            var x3 = del3(10, "Piotr", DateTime.Now);
            var s = sum(5, 20);
            consoleWriter(5, "Piotr");
        }

        // -------------------------------------------

        public void Test_WTF()
        {
            // No i na koniec coś bardziej popłyniętego czyli metody zwracające metody ;)
            // a konkretnie w poniższym przypadku mam metodę, która przyjmuje int'a i zwraca metodę, która przyjmuje double i zwraca string'a ;)

            Func<int, Func<double, string>> del = x =>
            {
                if (x == 0) // jak 0 to...
                {
                    return y => "Piotr"; // zwracamy metodę, która zwraca "Piotr"
                }
                else // ... a w przeciwnym wypadku ...
                {
                    return y => (y * x).ToString(); // zwraca metodę, która zwraca y * x jako string;
                }
            };

            // ... a teraz wywołanko:

            var s1 = del(0)(18.8);

            // ... oczywiście można to rozpisać:

            var m = del(0);
            var s2 = m(18.8);

            // No, a można mieć jeszcze bardzije pokręcone przypadki typu metoda, która zwraca metdoę, która zwrca metodę, która zwraca metodę itd... ;)

            Func<int, int, int, int, Func<string, double, Func<int, Func<DateTime, Func<int, Action<double>>>>>> del2 = null;
            del2 = (x1, x2, x3, x4) => (str, dbl) => z => someDate => p1 => m1 => { };
            del2(1, 2, 3, 4)("Piotr", 19.195)(33)(DateTime.Now)(27)(0.28423); // czyli tutaj każde wywołanie zwraca kolejną metodę, którą można wywołać, a to zwraca kolejną metodę itd.

            // no i podsumowując - nikt tak w praktyce nie pisze bo to jest wybitnie nieczytelne - ale dać się da więc pokazuję ;)
        }


    }

    // Delegat w najprostrzej postaci czyli jest to typ wskazujący na metodę - czyli może posłużyć do tego żeby mieć coś takiego co w C/C++ nazywa się wskaźnikiem na metodę - w .NET mówi się na to delegat.
    public delegate string StringModifierDelegate(string inputString);

    // Inny przykład - delegat odpowiadający metodzie, która nie przyjmuje parametrów i nic nie zwraca (void).
    public delegate void DoSomethingDelegate();

    // Jeszcze inny przykład delegatu reprezentującego metodę do sorotowania listy int'ów.
    public delegate List<int> SortDelegate(List<int> notSortedList);

    // A teraz coś nieco ciekawszego czyli ten sam delegat co wyżej ale do sortowania dowolnej listy.
    public delegate List<T> GenericSortDelegate<T>(List<T> notSortedList);

    // A teraz taki bardzo ogólny delegat metody, która przyjmuje jakieś trzy parametry i zwraca jakąś wartość
    public delegate TResult PiotrFunc<TParam1, TParam2, TParam3, TResult>(TParam1 p1, TParam2 p2, TParam3 p3);
    // ... a to już bardzo przypomina delegat Func<T1, T2, T3, TResult> z namespace'u System dostarczony razem ze standardowymi systemowy dll'kami, a konkretnie mscorlib.dll
    // ... a na potrzeby metod, które nie mają rezultatu czyli void zamiast Func wymyślono Action, np Action<T1, T2, T3, T4, T5>

    public class SumatorsTest
    {
        public void Sumator1_Test()
        {
            var sumator = new Sumator1();

            // sybskrypcja dwóch metod pod event - tu mamy dwie subskrybcje w jednej klasie ale zwykle w praktyce kilka klas subskrybuje pod zdarzenie z jakiegoś obiektu i każda z tych klas reaguje na to zdarzenie po swojemu.
            // Natomiast Sumator ma to gdzieś, on tylko liczy sumę i rzuca event, że ją policzył na zasadzie - chcecie to korzytajcie z tej infroamcji, że coś zrobiłem, a jak nie to nie.
            sumator.ValueAdded += Sumator_ValueAdded_1;
            sumator.ValueAdded += Sumator_ValueAdded_2;

            sumator.Add(100);

            // odsubskrybowanie
            sumator.ValueAdded -= Sumator_ValueAdded_1;
            sumator.ValueAdded -= Sumator_ValueAdded_2;
        }

        private void Sumator_ValueAdded_1(double totalValue, double addedValue)
        {
            Console.WriteLine("Total: " + totalValue);
        }

        private void Sumator_ValueAdded_2(double totalValue, double addedValue)
        {
            Console.WriteLine("Added: " + addedValue);
        }

        // -------------------------------------------

        public void Sumator2_Test()
        {
            var listeners = new ISumatorListener[]
            {
                new TotalValueSumatorListener(),
                new AddedValueSumatorListener(),
            };

            var sumator = new Sumator2(listeners);

            sumator.Add(100);

        }
    }

    // No i na sam koniec przykład wykorzystania delegatów w eventach:
    public class Sumator1
    {
        private double _totalValue;

        // Jest sobie klasa Sumator, która rzuca/wywołuje zdarzenie ValueAdded. To zdarzenie jest wywoływane po dodaniu wartości do sumatora.
        // Zdarzenie ma informować każdego nasłuchującego na to zdarzenie o tym jaka jest suma całkowita i jaką wartość przed chwilą dodano.
        // Dzięki eventom można zrealizować bardzo istotną rzecz czyli odciążyć klasę Sumator - teraz klasa Sumator nie musi w ogóle wiedzieć kto
        // nasłuchuje na eventy - na event ValueAdded może nikt nie nasłuchiwać, może nasłuchiwać jedna klasa, albo milion klas.
        // To pełni w tym kontekście podobną funkcję jak interfejs, który byśmy wstrzyknęli do klasy sumatora...
        // I mówimy na to decoupling czyli takie rozdzielenie klas, że nie są one sztywno połączone i od siebie zależne
        public event SumatorEventHandler ValueAdded; // magiczne słowo kluczowe event powoduje, do ValueAdded możemy przypisać nie jedną metodę tylko wiele i nie robimy tego tak: ValueAdded = costam tylko ValueAdded += costam

        public void Add(double value)
        {
            _totalValue += value;

            if (ValueAdded != null)
            {
                ValueAdded(_totalValue, value);
            }
        }
    }

    public delegate void SumatorEventHandler(double totalValue, double addedValue);

    // A tutaj dokładnie ten sam cel zrealizowany ale z użyciem interfejsu zamiast eventu:

    public class Sumator2
    {
        private readonly ISumatorListener[] _listeners;
        private double _totalValue;

        public Sumator2(ISumatorListener[] listeners)
        {
            _listeners = listeners ?? throw new ArgumentNullException(nameof(listeners));
        }

        public void Add(double value)
        {
            _totalValue += value;

            foreach (var listener in _listeners)
            {
                listener.OnValueAdded(_totalValue, value);
            }
        }
    }

    public interface ISumatorListener
    {
        void OnValueAdded(double totalValue, double addedValue);
    }

    public class TotalValueSumatorListener : ISumatorListener
    {
        public void OnValueAdded(double totalValue, double addedValue)
        {
            Console.WriteLine("Total: " + totalValue);
        }
    }

    public class AddedValueSumatorListener : ISumatorListener
    {
        public void OnValueAdded(double totalValue, double addedValue)
        {
            Console.WriteLine("Added: " + addedValue);
        }
    }
}