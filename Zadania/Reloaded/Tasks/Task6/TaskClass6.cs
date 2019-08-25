using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task6
{
    public class TaskClass6
    {
        public void Test()
        {
            int[] tab = new int[999];
            int[] tab1 = new int[999];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (i % 2 == 0) //przypomniało się modulo z C
                {
                    tab1[i] = tab[i] * 3;
                }
                else
                {
                    tab1[i] = tab[i] * (-1);
                }
            }
        }
    }
}
