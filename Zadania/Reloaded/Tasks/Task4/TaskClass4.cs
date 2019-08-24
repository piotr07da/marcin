using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task4
{
    public class TaskClass4
    {
        public void Test()
        {
            int[] tab = new int[100];
            int[] tab1 = new int[100];
            
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 55 + i ;
                tab1[i] = tab[i]; //w zadaniu jest "Przepisz" więc nie wiem czy nie w osobnej pętli ??
            }

        }
    }
}
