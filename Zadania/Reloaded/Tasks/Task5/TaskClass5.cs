using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task5
{
    public class TaskClass5 //przed tem nie było : public, i też działało
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
