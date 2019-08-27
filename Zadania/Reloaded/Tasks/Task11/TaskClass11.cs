using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task11
{
    public class TaskClass11
    {
        public void Test()
        {
            for (; ; )
            {
                Console.Clear();
                Console.Write("Wpisz tekst, tylko nie - socjalizm : ");
                string tekst;
                tekst = Console.ReadLine();
                if (tekst == "socjalizm")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nie socjalizm kurwa");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wpisałeś : " + tekst.ToUpper());
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
