using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reloaded.Tasks.Task20
{
    public class TaskClass20
    {
        public void Test()
        {
            for (; ; )
            {


                Console.Clear();

                Console.Write("Podaj ścieżkę pliku : ");

                string filepath = Console.ReadLine();
                try
                {
                    string text = File.ReadAllText(filepath);

                    Console.WriteLine(text);

                    Console.ReadKey();

                    break;
                }
                
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Console.ReadKey();
            }
        }
    }
}
