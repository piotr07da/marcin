using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16d
{
    public class TestClass16d
    {
        public void Test()
        {
            var richText = new RichTekst("MarciN", "-", LetterCase.Original, true, true, ConsoleColor.Yellow);
            richText.Show();
            Console.ReadKey();
        }
    }
}
