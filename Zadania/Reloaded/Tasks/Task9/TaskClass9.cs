using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task9
{
    public class TaskClass9
    {
        public void Test()
        {
            int[] tab = new int[20];
            List<int> tabList = new  List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 1)
                {
                    tabList.Add (tab[i]);
                }
            }
           
            //chiałem dać to w nowej metodzie ale tam nie widział listy

            Console.WriteLine("for : ");
            for (int i = 0; i < tabList.Count; i++)
            {
                Console.Write(tabList[i] + ",");
            }


            Console.WriteLine("");
            Console.WriteLine("While : ");
            int a = 0;
            while(a < tabList.Count)
            {
                Console.Write(tabList[a] + ",");
                a++;
            }

            Console.WriteLine("");
            Console.WriteLine("Foreach : ");

            foreach (var current in tabList)
            {
                Console.Write(current + ",");
            }

            Console.ReadKey();
        }
    }
}
