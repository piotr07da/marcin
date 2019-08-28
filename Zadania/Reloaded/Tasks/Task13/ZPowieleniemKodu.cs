using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task13
{
    public class ZPowieleniemKodu
    {
        public void Test()
        {
            int x1, x2, x3, x4, x5, x6;

            Console.WriteLine("1.");
            Console.WriteLine("******************");
            Console.WriteLine("wiadomość pierwsza");
            Console.WriteLine("##################");
            x1 = "wiadomość pierwsza".Length;

            Console.WriteLine("2.");
            Console.WriteLine("******************");
            Console.WriteLine("wiadomość druga");
            Console.WriteLine("##################");
            x2 = "wiadomość druga".Length;

            Console.WriteLine("3.");
            Console.WriteLine("******************");
            Console.WriteLine("wiadomość trzecia");
            Console.WriteLine("##################");
            x3 = "wiadomość trzecia".Length;

            Console.WriteLine("4.");
            Console.WriteLine("******************");
            Console.WriteLine("wiadomość czwarta");
            Console.WriteLine("##################");
            x4 = "wiadomość czwarta".Length;

            Console.WriteLine("5.");
            Console.WriteLine("******************");
            Console.WriteLine("wiadomość piąta");
            Console.WriteLine("##################");
            x5 = "wiadomość piąta".Length;

            Console.WriteLine("6.");
            Console.WriteLine("******************");
            Console.WriteLine("wiadomość szósta");
            Console.WriteLine("##################");
            x6 = "wiadomość szósta".Length;

            Console.WriteLine(x1 + x2 + x3 + x4 + x5 + x6);
        }
    }
}
