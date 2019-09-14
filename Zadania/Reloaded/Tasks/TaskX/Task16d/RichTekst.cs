using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16d
{
    public class RichTekst
    {
        public RichTekst(string text, string letterseparator, LetterCase letterCase ,bool underline, bool reverseOrder,ConsoleColor consoleColor )
        {
            Tekst = text;
            LetterSeparator = letterseparator;
            LetterCase = letterCase;
            Underline = underline;
            ReverseOrder = reverseOrder;
            ConsoleColor = consoleColor;
        }
        public string Tekst { get; set; }
        public string LetterSeparator { get; set; }
        public LetterCase LetterCase { get; set; }
        public bool Underline { get; set; }
        public bool ReverseOrder { get; set; }
        public ConsoleColor ConsoleColor { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor;

            var tempText = Tekst;

            if (LetterCase == LetterCase.Upper)
            {
                tempText = Tekst.ToUpper();
            }
            else if (LetterCase == LetterCase.Lowwer)
            {
                tempText = Tekst.ToLower();
            }
            else { };

            if (ReverseOrder)
            {
                var tempText2 = string.Empty;
                for (int i = 0; i < tempText.Length; i++)
                {
                    tempText2 += tempText[tempText.Length - 1 - i];
                }
                tempText = tempText2;
            }

            if(!(LetterSeparator == null))
            {
                var tempText2 = string.Empty;
                for (int i = 0; i < tempText.Length; i++)
                {
                    if (i > 0) { tempText2 += LetterSeparator; }
                    tempText2 += tempText[i];
                }
                tempText = tempText2;
            }

            Console.WriteLine(tempText);

            if (Underline)
                
            {
                for (int i = 0; i < tempText.Length; i++)
                {
                    Console.Write("_");
                   
                }
            }
        }
    }
    public enum LetterCase
    {
        Original,
        Upper,
        Lowwer,
    }
    
}
