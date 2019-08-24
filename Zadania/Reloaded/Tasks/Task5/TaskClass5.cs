using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task5
{
    class TaskClass5
    {
        public void Test()
        {
            int[] tab = new int[999];
            int[] tab1 = new int[999];
            
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i ;
                tab1[i] = tab[i] * 15;
            }
        }
    }
}
