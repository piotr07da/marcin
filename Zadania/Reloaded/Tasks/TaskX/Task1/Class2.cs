using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task1
{
    public class Class2
    {
        public void Test()
        {
            DoSomethingDelegate del = null;
            DoSomethingDelegate del2 = null;
            
            del = DoSomethingDel;
            del();

            del = DoSomethingDel2;
            del();

            del2 = () => { Console.WriteLine("333"); };

            Console.ReadKey();
            Console.Clear();
            del();
            del2();
            Console.ReadKey();
        }

        private void DoSomethingDel()
        {
            Console.WriteLine("111");
        }

        private void DoSomethingDel2()
        {
            Console.WriteLine("222");
        }       

        public delegate void DoSomethingDelegate();
    }
}
