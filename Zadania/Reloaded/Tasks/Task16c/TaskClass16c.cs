using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16c
{
    public class TaskClass16c
    {
        public void Test()
        {
            var funkcjaLiniowa = new FunkcjaLiniowa(10, -12);
            funkcjaLiniowa.ObliczWartosc(3);
            funkcjaLiniowa.ObliczMiejsceZerowe();
        }
    }
}
