using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task2
{
    public class TaskClass2
    {
        public void Test()
        {
            int[] tab2 = new int[1000];

            int a = -4; // :)

            for (int i = 0; i < tab2.Length; i++) 
            {
                tab2[i] = a;
                a += 2;
            }
        }
    }
}
