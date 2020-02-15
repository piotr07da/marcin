using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reloaded.Tasks.Task25
{
    public class TaskClass25
    {
        //string textPl;
        //string textEn;
        //string textZh;
        public void Test()
        {
            var stat = new CultureLanguageStatistics();

            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Podaj ścieżkę do katalogu, np : \"Culture\" : ");
                Console.WriteLine("");
                string path = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");

                if (File.Exists($"{path}\\text.pl-PL.txt"))
                {
                    stat.TextPl = File.ReadAllText($"{path}\\text.pl-PL.txt");
                }
                else { Console.WriteLine("Brak pliku"); }

                if (File.Exists($"{path}\\text.en-US.txt"))
                {
                    stat.TextEn = File.ReadAllText($"{path}\\text.en-US.txt");
                }
                else { Console.WriteLine("Brak pliku"); }

                if (File.Exists($"{path}\\text.zh-HK.txt"))
                {
                    stat.TextZh = File.ReadAllText($"{path}\\text.zh-HK.txt");
                }
                else { Console.WriteLine("Brak pliku"); }

                if (!(string.IsNullOrEmpty(stat.TextPl) && string.IsNullOrEmpty(stat.TextEn) && string.IsNullOrEmpty(stat.TextZh))) { break; }

                Console.ReadKey();
            }

            stat.ShowStat();
        }

        public void Example(string path)
        {
            string[] files = Directory.GetFiles(path);

            List<string> texts = new List<string>();
            foreach(var file in files)
            {
                texts.Add(File.ReadAllText(file));
            }
        }
    }
}
