using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task16d
{
    public class RichText
    {
        public RichText(string text, string letterSeparator, LetterCaseType letterCase,  ConsoleColor color)
        {
            Text = text;
            LetterSeparator = letterSeparator;
            LetterCase = letterCase;
            Color = color;
            

        }
        public string Text { get; set; }
        public string LetterSeparator { get; set; }
       
        public LetterCaseType LetterCase { get; set; }

        private bool _underline;
        public bool Underline { get { return _underline; } }

        private bool _reverseOrder;
        public bool RewerseOrder { get { return _reverseOrder; } }
        

        public ConsoleColor Color { get; set; }

        public void Show(bool underline, bool rewerseOrder)
        {
            var temporaryText = Text;


            if (Color==ConsoleColor.Red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (LetterCase == LetterCaseType.Upper)
            {
                temporaryText = temporaryText.ToUpper();
            }
            else if(LetterCase==LetterCaseType.Lowwer)
            {
                temporaryText = temporaryText.ToLower();
            }

          if (RewerseOrder == true)
            {
                var tab = temporaryText.ToCharArray();
                for (int i = 0; i < temporaryText.Length; i++)
                {
                    tab[i] = temporaryText[temporaryText.Length - 1 - i];
                }
                temporaryText = tab.ToString();
            }
          if (!(LetterSeparator == null))
            {

            }

            Console.WriteLine(temporaryText);
            Console.ReadKey();

        }

        public enum LetterCaseType
        {
            Original,
            Upper,
            Lowwer,
        }
    }
}
