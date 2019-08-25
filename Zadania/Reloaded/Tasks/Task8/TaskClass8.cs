using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task8
{
    public class TaskClass8
    {

        public void Test()
        {
            int[] tab = new int[20];
            List<int> tabList = new List<int>();


            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 10 + i * 2;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                tabList.Add(tab[i]);
            }
        }
    }
}
