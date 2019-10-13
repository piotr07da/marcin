using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task25
{
    public class ElementCalculations
    {
        public int value;
        public int occurs;
        public int index;

        public void SortData(int[] data, List<ElementCalculations> list)
        {
            Sort(data,list);
        }

        static private int Compare(ElementCalculations a, ElementCalculations b) // ??? - Metoda przekazywana do metody Sort powinna działać tak, że jak pierwszy element jest większy to zwraca -1, jak drugi jest większy to zwraca 1, a jak są równe to zwraca 0. Ale Twoja metoda też zadziała.
        {
            if (a.occurs != b.occurs)
                return (b.occurs - a.occurs);
            else return a.index - b.index;
        }
        


        public static int[] Sort(int[] data, List<ElementCalculations> list)
        {
           
            int p = 0;
            for (int i = 0; i < data.Length; i++)
            {
                p = 0;
                while (p < list.Count && data[i] > list[p].value)
                    p++;
                if (list.Count == p || data[i] != list[p].value)
                {
                    ElementCalculations el = new ElementCalculations();
                    el.value = data[i];
                    el.occurs = 0;
                    el.index = i;
                    list.Insert(p, el);   // ??? - rozumiem po co to jest - wstawiasz sobie te elementy do listy posortowane na wartości znaku czyli a, b, c, d itd. Rozumiem, tylko nie rozumiem w jakim celu skoro 4 linijki niżej sortujesz to i tak po occurs.
                    //                             to znaczy wiem, że jest Ci to potrzebne żeby znaleźć element, w którym zwiększasz occurs. Ale to można zrobić prościej - poniżej pod tą klasą podam dwa mini-example.
                }
                list[p].occurs++;
            }
            list.Sort(Compare);    // ??? - spoko, ale wszystko co poniżej chyba nie jest potrzebne albo czegoś nie rozumiem ;)
            int[] w = new int[data.Length];
            p = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].occurs; j++)
                {
                    w[p++] = list[i].value;
                }
            }
            return w; // ??? - tego nie rozumiem - zwracasz jakąś tablicę z metody - tylko po co skoro tę metodę wywołujesz tylko raz w metodzie SortData i tego wyniku nie przypisuejsz do żadnej zmiennej. Całe to liczenie w jest niepotrzebne. Kod działa i jak rozumiem sortuje litery czy coś w tym stylu ;)
        }
    }

    public class ElementCalculationsExample
    {
        public void Opcja1(int[] data, List<ElementCalculations> list)
        {
            for (var i = 0; i < data.Length; ++i)
            {
                var el = list.FirstOrDefault(ec => ec.value == data[i]); // wyciągamy pierwszy (FIRST), który spełnia warunek, a (OR) jak takiego nie znajdziemy to null (DEAFAULT) - wada tego rozwiązania - FirstOrDefault za każdym razemu musi przeiterować po całej liscie żeby odnaleźć element spełniający warunek - to się opłaca przy małych listach
                if (el == null) // jak nie znaleźliśmy to tworzymy nowy i dodajemy do listy
                {
                    el = new ElementCalculations();
                    el.value = data[i];
                    el.occurs = 0;
                    el.index = i;
                    list.Add(el); // dodajemy element do listy
                }
                el.occurs++;
            }
        }

        public void Opcja2(int[] data, List<ElementCalculations> list)
        {
            var dict = new Dictionary<int, ElementCalculations>(); // tworzymy słownik, w którym kluczem jest int, a wartością ElementCalculations

            for (var i = 0; i < data.Length; ++i)
            {
                dict.TryGetValue(data[i], out ElementCalculations el); // próbujemy wciągnąć element ze słownika na podstawie data[i] - wada tego rozwiązania - za każdym razem TryGetValue liczy hash funkcją hashującą po to żeby wybrać element ze słownika - to się opłaca przy dużych słownikach
                if (el == null) // jak nie znaleźliśmy to tworzymy nowy i dodajemy do listy
                {
                    el = new ElementCalculations();
                    el.value = data[i];
                    el.occurs = 0;
                    el.index = i;
                    dict.Add(data[i], el); // dodajemy element do słownika
                }
                el.occurs++;
            }

            foreach(var kvp in dict) // Przepisujemy wartości ze słownika do listy
            {
                list.Add(kvp.Value);
            }
        }
    }
}
