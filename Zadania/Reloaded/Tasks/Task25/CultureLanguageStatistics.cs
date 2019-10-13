using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// UWAGI:
// 1. Coś tu nie pasuje - jeżeli spacja występuje 4826 razy, a litera "a" występuje 1682 razy to znaczy, że spacja występuje 2.87 razy więcej niż "a".
//    " " 4826 razy, o 3144 razy wiecej niz "a"
//    "a" 1682 razy, o 93 razy wiecej niz "e" i o 3144 razy mniej niz " "
//    "e" 1589 razy, o 85 razy wiecej niz "i" i o 93 razy mniej niz "a"
//    "i" 1504 razy, o 178 razy wiecej niz "o" i o 85 razy mniej niz "e"
// 2. Zmieniam zasady - chcę widzieć nie 4 najczęstsze znaki tylko wszystkie ;) DRY ;P
// 3. Zmieniam zasady - chcę żeby program obsługiwał każdą możliwą kulturę :) nie ważne ile będzie plików o nazwie text.##-##.txt to chcę żeby się wyśtwietlały wszystki - czyli jak nie ma plików to wyświetli się informacja, że nie ma plików,
//    a jak jest jeden plik to wyświetlą się statystki tylko dla jednego, a jak jest 100 plików to wyświetlą się dane dla wszystkich stu.

namespace Reloaded.Tasks.Task25
{
    public class CultureLanguageStatistics
    {                 

        public  string TextPl { get; set; }
        public string TextEn { get; set; }
        public string TextZh { get; set; }
        public void ShowStat()

        {
            List<ElementCalculations> listTextPl = new List<ElementCalculations>();
            List<ElementCalculations> listTextEn = new List<ElementCalculations>();
            List<ElementCalculations> listTextZh = new List<ElementCalculations>();

            var element = new ElementCalculations();

            int[] textPl = new int[TextPl.Length];
            int[] textEn = new int[TextEn.Length];
            int[] textZh = new int[TextZh.Length];
           
            for (int i = 0; i < TextPl.Length; i++)
            {
                textPl[i] = TextPl[i];
            }

            for (int i = 0; i < TextEn.Length; i++)
            {
                textEn[i] = TextEn[i];
            }

            for (int i = 0; i < TextZh.Length; i++)
            {
                textZh[i] = TextZh[i];
            }

            element.SortData(textPl, listTextPl);
            element.SortData(textEn, listTextEn);
            element.SortData(textZh, listTextZh);

            Show("Pl", listTextPl);
            Show("En", listTextEn);
            Show("Zh", listTextZh);

            Console.ReadKey();
            
        }
        private void Show(string contry, List<ElementCalculations> list)
        {
            Console.WriteLine($"Statystyki dla tekstu {contry} :" );
            
            Console.WriteLine("Najczęśćiej występuje kolejno : ");
            Console.WriteLine("");
            Console.WriteLine($"\"{(char)list[0].value}\" {list[0].occurs} razy, o {list[0].occurs - list[1].occurs} razy więcej niż \"{(char)list[1].value}\" ");
            Console.WriteLine($"\"{(char)list[1].value}\" {list[1].occurs} razy, o {list[1].occurs - list[2].occurs} razy więcej niż \"{(char)list[2].value}\" i o {list[0].occurs - list[1].occurs} razy mniej niż \"{(char)list[0].value}\" ");
            Console.WriteLine($"\"{(char)list[2].value}\" {list[2].occurs} razy, o {list[2].occurs - list[3].occurs} razy więcej niż \"{(char)list[3].value}\" i o {list[1].occurs - list[2].occurs} razy mniej niż \"{(char)list[1].value}\" ");
            Console.WriteLine($"\"{(char)list[3].value}\" {list[3].occurs} razy, o {list[3].occurs - list[4].occurs} razy więcej niż \"{(char)list[4].value}\" i o {list[2].occurs - list[3].occurs} razy mniej niż \"{(char)list[2].value}\" ");

            Console.WriteLine("");
           
        }
    }
}
