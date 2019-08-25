using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task10
{
    public class TaskClass10
    {
        public void Test()     
        {
            Console.Clear();
            Console.Write("Wpisz jakiś tekst : ");
            string tekst;
            tekst = Console.ReadLine();
            Console.WriteLine("Wpisałeś : " + tekst);
            Console.ReadKey();

        }
    }
}
