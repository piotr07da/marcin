using System;


namespace Reloaded.Tasks.Task16d
{
    public class PIOTR_2_RichText
    {
        public PIOTR_2_RichText(string text, string letterSeparator, LetterCaseType letterCase,  ConsoleColor color, bool underline, bool reverseOrder)
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
            var tempText = Text;

            tempText = ApplyLetterCase(tempText);
            tempText = ApplyReverseOrder(tempText);
            tempText = ApplyLetterSeparator(tempText);

            Console.ForegroundColor = Color;

            Console.WriteLine(tempText);
            if (Underline)
            {
                for (int i = 0; i < tempText.Length; i++)
                {
                    Console.Write("_");
                }
            }
            Console.ReadKey();
        }

        private string ApplyLetterCase(string txt)
        {
            switch (LetterCase)
            {
                case LetterCaseType.Lower:
                    return txt.ToLower();

                case LetterCaseType.Upper:
                    return txt.ToUpper();
            }

            return txt;
        }

        private string ApplyReverseOrder(string txt)
        {
            if (ReverseOrder)
            {
                var newText = string.Empty;
                for (int i = 0; i < txt.Length; i++)
                {
                    newText += txt[txt.Length - 1 - i];
                }
                return newText;
            }

            return txt;
        }

        private string ApplyLetterSeparator(string txt)
        {
            if (!string.IsNullOrEmpty(LetterSeparator))
            {
                var netText = string.Empty;
                for (int i = 0; i < txt.Length; i++)
                {
                    if (i > 0)
                    {
                        netText += LetterSeparator;
                    }
                    netText += txt[i];
                }
                txt = netText;
            }

            return txt;
        }

        public enum LetterCaseType
        {
            Original,
            Upper,
            Lower,
        }
    }
}
