using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16a
{
    public class TaskClass16aX
    {
        public void Test()
        {
            var autorKsiazki = new AutorKsiazki("Mirosław", "Kardaś");
            var book = new Book("Programowanie", 2013, autorKsiazki, "Kursk", 519);

            var autorKsiazki2 = new AutorKsiazki("Leonid", "Tyczka");
            var book2 = new Book("Patatajnia", 2000, autorKsiazki2, "Czemlewo", 11);

            book.Wypozycz();
            book.Oddaj();
            book.Wypozycz();
            book.Oddaj();
            book2.Wypozycz();
            
        }
    }
}
