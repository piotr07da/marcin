using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace Reloaded.Tasks.Task22
{
    public class TaskClass22

    {
        
        public int Line { get; set; }
        public int Sing { get; set; }
        public int Space { get; set; }
        public int Hash { get; set; }
        public int HashTwoNeighbor { get; set; }

        public void Test()
        {
            var drawing = new Drawing();

            string[] text = File.ReadAllLines(@"Tasks\Task22\spaceship.txt");

            foreach (var line in text)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
            Console.Clear();


            for (int line = 0; line < text.Length; line++)
            {
                for (int sing = 0; sing < text[line].Length; sing++)
                {

                    if (text[line][sing] == ' ')
                    {
                        Space += 1;
                    }
                    if (text[line][sing] == '#')
                    {
                        Hash += 1;
                    }
                   
                    if (text[line][sing] == '#')
                    {
                        if (text[line][sing - 1] == '#' && text[line][sing + 1] == '#')
                        {
                            HashTwoNeighbor += 1;
                        }
                    }
                    if (text[line][sing] == '#')
                    {
                        drawing.DrawObjects(Sing, Line, Color.Blue);
                    }

                    Sing = sing + 1;
                }
                //try
                //{
                    if (text[line].Length == text[0].Length) { }
                    else { throw new Exception("Error sing in Line"); }
                //}
                //catch(Exception ex)
                //{
                //    Console.WriteLine(ex);
                //}
                Line = line + 1;

            }
            //Console.WriteLine("Linie " + Line);
            //Console.WriteLine("Znaki " + Sing);
            //Console.WriteLine("Spacje " + Space);
            //Console.WriteLine("Krzyżyki " + Hash);
            //Console.WriteLine("Krzyżyk z dwoma sąsiadami " + HashTwoNeighbor);
            Console.ReadKey();
        }
    }
}
