using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task12
{
    public class TaskClass12
    {
        public void Test()
        {
            for (; ; )
            {
                string[] tab = new string[] { "kurwa", "jebany", "pizda", "huj", "cwel" };
                Console.Clear();
                Console.Write("Wpisz słowo, tylko nie przeklinaj i nie pisz komunizm : ");
                string text;
                text = Console.ReadLine();

                int a=0 ;

                for (int i = 0; i < tab.Length; i++)
                {
                    if (text == tab[i])
                    {
                        a = 1;
                        break;
                    }
                }

                if (a == 1)
                {
                    Console.WriteLine("Nie przeklinaj : ({0})", text);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (text == "komunizm")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Gierek for ever !!!");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wpisałeś : " + text.ToLower());
                    Console.ReadKey();
                    break;
                }
            }
            
        }
    }
}
