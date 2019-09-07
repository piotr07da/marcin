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
                Console.ForegroundColor = Color;
            //}
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
                var temporaryText2 = "";
                for (int i = 0; i < temporaryText.Length; i++)
                {
                    tab[i] = temporaryText[temporaryText.Length - 1 - i];
                }
               
                for (int i = 0; i < tab.Length; i++)
                {
                  
                    temporaryText2  = temporaryText2 + tab[i];
                }
                temporaryText = temporaryText2;
                
            }
          if (!(LetterSeparator == null))
            {
                var tab = temporaryText.ToCharArray();
                var temporaryText2 = "";
                for (int i = 0; i < tab.Length ; i++)
                {
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

        public enum LetterCaseType
        {
            Original,
            Upper,
            Lowwer,
        }
    }
}
