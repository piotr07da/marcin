using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task25
{
    public class ElementCalculations
    {
        public int value;
        public int occurs;
        public int index;

        public void SortData(int[] data, List<ElementCalculations> list)
        {
            Sort(data,list);
        }

        static private int Compare(ElementCalculations a, ElementCalculations b) // ???
        {
            if (a.occurs != b.occurs)
                return (b.occurs - a.occurs);
            else return a.index - b.index;
        }
        


        public static int[] Sort(int[] data, List<ElementCalculations> list)
        {
           
            int p = 0;
            for (int i = 0; i < data.Length; i++)
            {
                p = 0;
                while (p < list.Count && data[i] > list[p].value)
                    p++;
                if (list.Count == p || data[i] != list[p].value)
                {
                    ElementCalculations el = new ElementCalculations();
                    el.value = data[i];
                    el.occurs = 0;
                    el.index = i;
                    list.Insert(p, el);   // ???
                }
                list[p].occurs++;
            }
            list.Sort(Compare);    // ???
            int[] w = new int[data.Length];
            p = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].occurs; j++)
                {
                    w[p++] = list[i].value;
                }
            }
            return w; // ???
        }
    }
}
