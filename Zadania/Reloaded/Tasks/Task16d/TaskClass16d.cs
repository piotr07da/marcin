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
            letterCase = RichText.LetterCaseType.Lowwer;
            var richTekst = new RichText("Piotr", "*", letterCase, ConsoleColor.Red, true, true);
            richTekst.Show();
           
        }
    }
}
