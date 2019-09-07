using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16d
{
    public class RichText
    {
        public RichText(string text, string letterSeparator, LetterCaseType letterCase,  ConsoleColor color, bool underline, bool reverseOrder)
        {
            Text = text;
            LetterSeparator = letterSeparator;
            LetterCase = letterCase;
            Color = color;
            RewerseOrder = reverseOrder;
            Underline = underline;
            

        }
        public string Text { get; set; }
        public string LetterSeparator { get; set; }
       
        public LetterCaseType LetterCase { get; set; }     

        //private bool _underline;
        public bool Underline { get; set; }

        //private bool _reverseOrder;
        public bool RewerseOrder { get; set; }
        

        public ConsoleColor Color { get; set; }

        public void Show()
        {
            var temporaryText = Text;
           
            //if (Color==ConsoleColor.Red)
            //{
                Console.ForegroundColor = Color; // [PIOTR] tak - ten if, który zakomentowałeś jest do wywalenia
            //}
            if (LetterCase == LetterCaseType.Upper)
            {
                temporaryText = temporaryText.ToUpper();
            }
            else if(LetterCase==LetterCaseType.Lowwer)
            {
                temporaryText = temporaryText.ToLower();
            }

          if (RewerseOrder == true) // [PIOTR] zamiast pisać: if (ReverseOrder == true) można napisać po prostu: if (ReverseOrder)
            {
                var tab = temporaryText.ToCharArray(); // [PIOTR] tu jest trochę namieszane. tab to Twoja tymczasowa tablica, którą dopiero wypełniasz więc wystarczyło by var tab = new char[temporaryText.Length]; czyli po prostu tablica znaków tego samego rozmiaru co temporaryText
                var temporaryText2 = "";
                for (int i = 0; i < temporaryText.Length; i++)
                {
                    // [PIOTR] tutaj zamiast przypisywać do tymczasowej tablicy to mógłbyś od razu pisać:
                    // temporaryText2 = temporaryText2 + temporaryText[temporaryText.Length - 1 - i];
                    // dzięki temu nie potrzebował byś zupełnie tej drugiej pętli
                    // no bo teraz to tutaj wpisujesz znaki do tymczasowej tablicy, a w drugiej pętli przepisujesz z tymczasowej tablicy do temporaryText2 - niepotrzebna robota

                    tab[i] = temporaryText[temporaryText.Length - 1 - i];
                }
               
                for (int i = 0; i < tab.Length; i++)
                {
                  
                    temporaryText2  = temporaryText2 + tab[i];
                }
                temporaryText = temporaryText2;
                
            }
          if (!(LetterSeparator == null)) // [PIOTR] zamiast pisać: if (!(LetterSeparator == null)) można napisać prościej: if (LetterSeparator != null)
            {
                var tab = temporaryText.ToCharArray();
                var temporaryText2 = "";
                for (int i = 0; i < tab.Length ; i++)
                {
                    // [PIOTR] poniższą linię wystarczy rozbić w taki sposób żeby w każdym wywołaniu pętli dodawać znak z pierwotnego tekstu, ale separator dodawać po tym znaku tylko wtedy gdy i != tab.Length - 1 --- czyli po ostatni znaku nie dodasz
                    temporaryText2 = temporaryText2 + tab[i] + LetterSeparator;
                }
                temporaryText = temporaryText2;
            }

            Console.WriteLine(temporaryText);
            if (Underline)
            {
                for (int i = 0; i < temporaryText.Length; i++)
                {
                    Console.Write("_");
                }
            }
            Console.ReadKey();

        }

        public enum LetterCaseType // [PIOTR] enum lepiej deklarować poza klasą - bezpośrednio w namespace. Dzięki temu jak gdzieś poza klasą się do niego odwołujesz to nie musisz pisać RichText.LetterCaseType tylko bezpośrednio LetterCaseType
        {
            Original,
            Upper,
            Lowwer,
        }
    }
}
