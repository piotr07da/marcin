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
            //var letterCase = new RichText.LetterCaseType (); // [PIOTR] ta linijka jest zupełnie niepotrzebna - wystarczy w kolejnej linijce var na początku
            var letterCase = PIOTR_1_RichText.LetterCaseType.Upper;
            var richTekst = new PIOTR_1_RichText("Magda", "-", letterCase, ConsoleColor.Yellow, true, true);
            richTekst.Show();

            // [PIOTR] żeby ukazać zaletę takiego pisania kodu to warto tutaj zmienić richText.Text na jakiś inny i jeszcze raz wywołać metodę Show i wyobrazić sobie ile pisania kodu to zaoszczędza gdybyś teraz musiał wyświetlić 100 tekstów
           
        }
    }
}
