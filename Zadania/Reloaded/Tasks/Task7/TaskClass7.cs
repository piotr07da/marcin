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

            int a = 19;

            for (int i = 0; i < tab.Length; i++)
            {
                tab1[a] = tab[i];
                a--;
            }
        }
    }
}
