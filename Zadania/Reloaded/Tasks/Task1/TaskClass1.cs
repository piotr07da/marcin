using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task1
{
    public class TaskClass1
    {
        public void Test()
        {
            int[] tab1 = new int[100];

            for (int i = 0; i < tab1.Length ; i++)
            {
                tab1[i] = i + 800;
            }
        }

    }
}
