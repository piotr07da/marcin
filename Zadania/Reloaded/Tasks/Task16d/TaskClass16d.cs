using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16d
{
    public class TaskClass16d
    {
        public void Test()
        {
            var letterCase = new RichText.LetterCaseType ();
            letterCase = RichText.LetterCaseType.Upper;
            var richTekst = new RichText("Magda", "-", letterCase, ConsoleColor.Yellow, true, true);
            richTekst.Show();
           
        }
    }
}
