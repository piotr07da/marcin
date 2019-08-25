using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task7
{
    public class TaskClass7
    {
        public void Test()
        {
            int[] tab = new int[20];
            int[] tab1 = new int[20];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 10 + i * 2;
            }

            int a = 19; // [Piotr] tutaj można by napisać: int a = tab.Length - 1

            for (int i = 0; i < tab.Length; i++)
            {
                tab1[a] = tab[i];
                a--;
            }
        }

        // Tutaj alternatywna postać metody gdzie robimy bez dodatkowej zmiennej tylko za każdym razem wyliczamy index tablicy jako: tab.Length - 1 - i
        public void TestAlternative()
        {
            int[] tab = new int[20];
            int[] tab1 = new int[20];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 10 + i * 2;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                tab1[i] = tab[tab.Length - 1 - i];
            }
        }
    }

    // Tutaj rozwiązanie alternatywne, które eliminuje problem, który się pojawi jak zmienią się wymagania.
    // Np. jak powiem, że teraz trzeba zmienić rozmiar tablicy z 20 na 1000 to w Twoim rozwiązaniu będzie taki problem,
    // że będziesz musiał w dwóch miejscach w kodzie zmienić 20 na 1000 i w jednym miejscu 19, na 999.
    // W tym poniższym rozwiązaniu chodzi o to, że zmienić będziesz musiał tylko jedno miejsce.
    // W codziennym życiu programisty wymagania zmieniają się często i trzeba tak pisać kod żeby się jak najmniej narobić przy takich zmianach wymagań ;)
    public class TaskClass7Alternative
    {
        private const int SizeOfArrays = 20; // jedyne miejsce, które trzeba zmienić w przypadku gdy zmienią się wymagania dotyczące rozmiaru tablicy

        public void Test()
        {
            int[] tab = new int[SizeOfArrays]; // tutaj już nic zmieniać nie będzie trzeba bo:   korzystamy z consta
            int[] tab1 = new int[SizeOfArrays]; // tutaj już nic zmieniać nie będzie trzeba bo:   korzystamy z consta

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 10 + i * 2;
            }

            int a = tab.Length - 1; // tutaj już nic zmieniać nie będzie trzeba bo:   korzystamy property tab.Length

            for (int i = 0; i < tab.Length; i++)
            {
                tab1[a] = tab[i];
                a--;
            }
        }
    }
}
