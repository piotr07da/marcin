using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task1
{
    public class Class1
    {
        public void Test()
        {
            int[] tab = new int[20];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }
            List<int> tabList = new List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                if (i % 2 == 1)
                {
                    tabList.Add(tab[i]);
                }
            }

            for (int i = 0; i < tabList.Count; i++)
            {
                Console.Write(tabList[i] + ", ");
            }
            Console.WriteLine();
            foreach (var item in tabList)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            int a = 0;
            while (a < tabList.Count)
            {
                Console.Write(tabList[a] + ", ");
                a++;
            }
            Console.ReadKey();
        }

    }
}
