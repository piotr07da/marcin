using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task3
{
    public class TaskClass3
    {
        public void Test()
        {
            int[] tab3 = new int[10000];

            int a = 50;

            for (int i = 0; i < tab3.Length; i++)
            {
                tab3[i] = a;
                a += 10;
            }

        }
    }
}

