using System;
using System.Collections.Generic;

namespace Reloaded.Tasks.Task9
{
    public class TaskClass9
    {
        public void Test()
        {
            int[] tab = new int[20];
            List<int> tabList = new  List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 1)
                {
                    tabList.Add (tab[i]);
                }
            }
           
            //chiałem dać to w nowej metodzie ale tam nie widział listy

            Console.WriteLine("for : ");
            for (int i = 0; i < tabList.Count; i++)
            {
                Console.Write(tabList[i] + ",");
            }


            Console.WriteLine("");
            Console.WriteLine("While : ");
            int a = 0;
            while(a < tabList.Count)
            {
                Console.Write(tabList[a] + ",");
                a++;
            }

            Console.WriteLine("");
            Console.WriteLine("Foreach : ");

            foreach (var current in tabList)
            {
                Console.Write(current + ",");
            }

            Console.ReadKey();
        }
    }

    // Poniżej przykład w jaki sposób można PRZEKAZAĆ LISTĘ DO INNEJ METODY.
    public class TaskClass9_Example_1
    {
        public void Test()
        {
            var list = new List<int>(); // zmienna list jest widoczna tylko w kontekście metody Test - to jest zmienna lokalna

            ShowListUsingFor(list); // lokalną zmienną list przekazujemy do metody jako parametr tej metody
        }

        private void ShowListUsingFor(List<int> listToShow) // deklaracja, że metoda przyjmuje parametr typu List<int> (listToShow widoczne jest wyłącznie w środku metody ShowListUsingFor
        {
            Console.WriteLine("for : ");
            for (int i = 0; i < listToShow.Count; i++)
            {
                Console.Write(listToShow[i] + ",");
            }
        }
    }

    // Poniżej przykład w jaki sposób można WYKORZYSTAĆ POLE W KLASIE.
    public class TaskClass9_Example_2
    {
        private List<int> _list; // Deklaracja prywatnego pola _list; Pola są widoczne w obrębie każdej metody w tej klasie.

        public void Test()
        {
            _list = new List<int>(); // Inicjalizacja pola _list

            ShowListUsingFor();
        }

        private void ShowListUsingFor()
        {
            Console.WriteLine("for : ");
            for (int i = 0; i < _list.Count; i++) // odwołanie do pola _list
            {
                Console.Write(_list[i] + ",");
            }
        }
    }
}
