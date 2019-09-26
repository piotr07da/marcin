using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task22
{
    public class FileStatisticsGenerator
    {
        public void ShowStatistics(string[] text)
        {
            int line = 0;
            int sing = 0;
            int space = 0;
            int hash = 0;
            int hashTwoNeighbor = 0;
            for (line = 0; line < text.Length; line++)
            {
                for (sing = 0; sing < text[line].Length; sing++)
                {

                    if (text[line][sing] == ' ')
                    {
                        space += 1;
                    }
                    if (text[line][sing] == '#')
                    {
                        hash += 1;
                    }

                    if (text[line][sing] == '#')
                    {
                        if (text[line][sing - 1] == '#' && text[line][sing + 1] == '#')
                        {
                            hashTwoNeighbor += 1;
                        }
                    }

                    if (text[line].Length == text[0].Length) { }
                    else { throw new Exception("Error sing in Line"); }
                }
            }
           

            Console.WriteLine("Linie " + line);
            Console.WriteLine("Znaki " + sing);
            Console.WriteLine("Spacje " + space);
            Console.WriteLine("Krzyżyki " + hash);
            Console.WriteLine("Krzyżyk z dwoma sąsiadami " + hashTwoNeighbor);
                        
        }
    }
}
