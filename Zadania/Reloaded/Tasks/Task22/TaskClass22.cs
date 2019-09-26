using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

// Elegancko. To teraz jak już wiesz jak pobierać współrzędne i jak w ogóle nawigować po takiej dwuwymiarowej tablicy znaków to możesz spokojnie działać dalej ;)
// Widziałem w poprzednim commit, że elegancko się uruchamia i są niebieskie kwadraty także pięknie :D
// Ale ponieważ robi się tu trochę Sajgon to tak:
// 1. Cały kod odpowiedzialny za zbieranie tych statystyk daj do osobnej prywatnej metody - nazwijmy ją ShowStatistics(string[] lines) i tę metodę tylko wywołuj w odpowiednim miejscu w metodzie Test. Alternatywnie możesz w ogóle tę logikę wyrzucić do osobnej klasy, np. FileStatisticsGenerator. Jak tam wolisz.
// 2. Te property Line, Sing itd. zastąp lokalnymi zmiennymi w metodzie ShowStatistics bo nie ma potrzeby żeby to zapisywać jako property na poziomie klasy bo nic innego poza tą metodą nie będzie z tego i tak korzystać.
// 3. Nie mieszaj kodu odpowiedzialnego za statystyki z kodem odpowiedzialnym za rysowanie macierzy kwadratów.
//    Czyli na potrzebę rysowania kwadratów zrób sobie osobną metodę DrawCellMatrix i w niej ponownie zrób pętlę w pętli tak jak na potrzebę statystyk - to akurat nie złamie DRY
//    bo logika w tych pętlach będzie zupełnie inna, a to że obie metody muszą się przepętlić po naszej dwuwymiarowej tablicy znaków to muszą i trudno.
//    Odróżnianie powielonego kodu od podobnego kodu przychodzi z czasem.
// 4. W tej drugiej metodzie (DrawCellMatrix) nie korzystaj bezpośrednio z tablicy stringów wczytanej z pliku.
//    Zamiast tego napisz sobie metodę:
//    bool[,] ImportCellMatrix(string[] lines)
//    Ta metoda niech na podstawie tablicy stringów (czyli defacto dwuwymiarowej tablicy znaków) niech zwróci dwuwymiarową tablicę bool'i, w której dla znaku '#' umieścisz true, a dla znaku ' ' umieścisz false.
//    I dopiero na tej tablicy będzie operować metoda DrawCellMatrix.
//    A dlaczego tak? Dlatego, że to bardziej odzwierciedli to co jest napisane w zadaniu czyli fakt, że mamy mieć macierz komórek, które są żywe lub martwe - idealnie nadaje się tutaj albo standardowy bool albo nowy enum CellLifeState { Alive, Dead },
//    więc w sumie jak wolisz - możesz napisać albo metodę:
//    bool[,] ImportCellMatrix(string[] lines)
//    albo
//    LifeState[,] ImportCellMatrix(string[] lines)
//    To drugie ma pewną zaletę, która wyjdzie później ;)
//    A teraz jeżeli chodzi o klasę Drawing to dobrze kombiujesz z tym przekazaniem koloru. Tam trzeba tylko przekazać parametr color i zamknąć nawias od konstruktora SolidBrush ;) - jak jest za dużo rzeczy w jednej linii to też nie dobrze bo się zaczyna wszystko mieszać.
//    Warto sobie wtedy rozłożyć to na czynniki pierwsze i wyciągnąć to do osobnych zmiennych, np. brush, rectangle i dopiero wtedy przekazać te dwie zmienne do FillRectangle

namespace Reloaded.Tasks.Task22
{
    public class TaskClass22

    {




        public void Test()
        {

            var generat = new FileStatisticsGenerator();

            var drawing = new Drawing();

            string[] text = File.ReadAllLines(@"Tasks\Task22\spaceship.txt");

            foreach (var line in text)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
            Console.Clear();
            generat.ShowStatistics(text);
            Console.ReadKey();

                        
            Console.ReadKey();
        }
        private void DrawCellMatrix()
        {

        }


        private CellLifeState ImportCellMatrix(string[] text)
        {
            CellLifeState[,] lifeState = new CellLifeState[20, 47];
            for (int i = 0; i < text.Length; i++)
            {
                for (int a = 0; a < text[i].Length; a++)
                {
                    if (text[i][a] == '#')
                    {
                        lifeState[i, a] = CellLifeState.Alive;
                        //return lifeState[i, a];
                    }
                    else
                    {
                        lifeState[i, a] = CellLifeState.Dead;
                        //return lifeState[i, a];
                    }
                   
                }
                
            }

            //return lifeState[,];
        }
        enum CellLifeState
        {
            Alive,
            Dead,
        }
    }
}

