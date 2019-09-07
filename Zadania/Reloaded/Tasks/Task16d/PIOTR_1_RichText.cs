using System;


namespace Reloaded.Tasks.Task16d
{
    public class PIOTR_1_RichText
    {
        public PIOTR_1_RichText(string text, string letterSeparator, LetterCaseType letterCase,  ConsoleColor color, bool underline, bool reverseOrder)
        {
            Text = text;
            LetterSeparator = letterSeparator;
            LetterCase = letterCase;
            Color = color;
            ReverseOrder = reverseOrder;
            Underline = underline;
        }

        public string Text { get; set; }
        public string LetterSeparator { get; set; }
        public LetterCaseType LetterCase { get; set; }     
        public bool Underline { get; set; }
        public bool ReverseOrder { get; set; }
        public ConsoleColor Color { get; set; }

        public void Show()
        {
            var temporaryText = Text;

            Console.ForegroundColor = Color;

            switch (LetterCase)
            {
                case LetterCaseType.Lower:
                    temporaryText = temporaryText.ToLower();
                    break;

                case LetterCaseType.Upper:
                    temporaryText = temporaryText.ToUpper();
                    break;
            }

            if (ReverseOrder)
            {
                var temporaryText2 = string.Empty;
                for (int i = 0; i < temporaryText.Length; i++)
                {
                    temporaryText2 += temporaryText[temporaryText.Length - 1 - i];
                }
                temporaryText = temporaryText2;
            }

            if (!string.IsNullOrEmpty(LetterSeparator))
            {
                var temporaryText2 = string.Empty;
                for (int i = 0; i < temporaryText.Length; i++)
                {
                    temporaryText2 += temporaryText[i];
                    if (i < temporaryText.Length - 1)
                    {
                        temporaryText2 += LetterSeparator;
                    }
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
            Lower,
        }
    }
}
