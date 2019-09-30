using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Threading;

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



// UWAGI - część druga:
// Z metody Test możesz spokojnie usunąć:
// CellLifeState[,] tempLifeState = new CellLifeState[generat.line, generat.sing];
// oraz pętlę przepisującą elementy z lifeState do tempLifeState
// Metoda ReadyToFlow, WaitAsync, oraz Wait także nie potrzebuje argumentu tempLifeState. Argument zostaje tylko w metodzie Movement
// To jest tylko tymczasowa tablica i możesz ją sobie spokojnie stworzyć w metodzie ReadyToFlow w taki sposób:
// var tempLifeState = new CellLifeState[lifeState.GetLength(0), lifeState.GetLength(1)];
// ... ale UWAGA - tę tablicę musisz tworzyć nie na początku metody ReadyToFlow tylko w środku pętli for(; ; ) na samym początku - dzięki temu każdy kolejny krok przeliczający
// nowe stany komórek będzie otrzymywał nową tablicę, w której zostaną umieszczone nowe stany i nigdy podczas ustalania nowych stanów nie dojdzie do sytujacji,
// w której referencja do lifeState będzie równa referencji do tempLifeState. Gdybyś to zrobił na początku metody ReadyToFlow to w pierwszym przebiegu for(; ; ) wszystko będzie okej
// ale już w drugim referencja do lifeState będzie taka sama jak tempLifeState i wrócisz do sytuacji, w której miałeś jedną tablicę, a nie dwie.
// Czyli tempLifeState to jest za każdym krokiem nowa dwuwymiarowa tablica. Wyjaśniając: lifeState.GetLength(0) pobiera rozmiar pierwszego wymiaru tablicy lifeState,
// a lifeState.GetLength(1) pobiera rozmiar drugiego wymiaru tablicy lifeState.
// Dzięki temu utworzysz tempLifeState takich samych rozmiarów co lifeState.
// I teraz spokojnie możesz wywalić tę pętlę przepisującą z tempLifeState do lifeState a zamaist tego dać lifeState = tempLifeState.
// Czyli w metodzie ReadyToFlow w głównej pętli for(; ; ) to będzie miało teraz taki przepływ:
// 1. tworzysz nową tablicę tempLifeState
// 2. w pętli w pętli przy pomocy metody Movement do tablicy tempLifeState wpisujesz nowe stany komórek - czyli dokładnie tak jak masz teraz
// 3. do zmiennej lifeState przypisujesz tablicę referowaną przez zmienną tempLifeState (lifeState = tempLifeState) - no bo referencja do starych stanów jest nam już teraz niepoptrzebna więc można to nadpisać nowymi stanami.
// Ale jak tak to przerobisz to jeszcze nie będzie działać z jednego powodu:
// Bo domyślnie taka nowa tablica tempLifeState jest zainicjalizowana pierwszą wartością z enuma, a ta wartość to jest Alive,
// więc trzeba zadbać w metodzie Movement żeby w każdym przypadku nadpisać komórkę z tempLifeState i u Ciebie wiele do tego nie brakuje, a konkretnie brakuje jednego else:
// Zamiast:
// if (lifeState[i, a] == CellLifeState.Dead)
// {
//    if (neighborAlive == 3) { tempLifeState[i, a] = CellLifeState.Alive; }
// }
// Powinno być:
// if (lifeState[i, a] == CellLifeState.Dead)
// {
//    if (neighborAlive == 3) { tempLifeState[i, a] = CellLifeState.Alive; } else { tempLifeState[i, a] = CellLifeState.Dead; }
// }


namespace Reloaded.Tasks.Task22
{
    public class TaskClass22

    {
        
        public FileStatisticsGenerator generat = new FileStatisticsGenerator();

        public void Test()
        {
            var impor = new Importer();
                       
            var drawing = new Drawing();

            string[] text = File.ReadAllLines(@"Tasks\Task22\spaceship.txt");

            foreach (var line in text)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
            Console.Clear();
            generat.ShowStatistics(text);

            CellLifeState[,] lifeState = new CellLifeState[generat.line, generat.sing];
           
            Console.ReadKey();
            Console.Clear();
            impor.ImportCellMatrix(text, lifeState);

            

            DrawCellMatrix(lifeState);

            Console.ReadKey();

            Wait(lifeState);
        }
        private void DrawCellMatrix(CellLifeState[,] lifeState)
        {
            
           
            var draw = new Drawing();
           

            for (int i = 0; i < generat.line; i++)
            {
                for (int a = 0; a < generat.sing; a++)
                {
                    if (lifeState[i, a] == CellLifeState.Alive)
                    {
                        draw.DrawObjects(a, i, Color.Blue);
                    }
                    else
                    {
                       
                            draw.DrawObjects(a, i, Color.Yellow);
                            
                        
                    }
                }
            }
           
        }
        private void Movement(int i, int a,CellLifeState[,] lifeState,CellLifeState[,] tempLifeState)
        {
           
            int neighborAlive = 0;
            var draw = new Drawing();


            if (a > 0) { if (lifeState[i, a - 1] == CellLifeState.Alive) { neighborAlive += 1; } }
            if (a < generat.sing-1) { if (lifeState[i, a + 1] == CellLifeState.Alive) { neighborAlive += 1; } }
            if (i > 0 && a > 0) { if (lifeState[i - 1, a - 1] == CellLifeState.Alive) { neighborAlive += 1; } }
            if (i > 0) { if (lifeState[i - 1, a] == CellLifeState.Alive) { neighborAlive += 1; } }
            if (i > 0 && a < generat.sing-1) { if (lifeState[i - 1, a + 1] == CellLifeState.Alive) { neighborAlive += 1; } }
            if (i < generat.line-1 && a > 0) { if (lifeState[i + 1, a - 1] == CellLifeState.Alive) { neighborAlive += 1; } }
            if (i < generat.line-1) { if (lifeState[i + 1, a] == CellLifeState.Alive) { neighborAlive += 1; } }
            if (i < generat.line-1 && a < generat.sing-1) { if (lifeState[i + 1, a + 1] == CellLifeState.Alive) { neighborAlive += 1; } }




            if (lifeState[i, a] == CellLifeState.Dead)
            {
                if (neighborAlive == 3) { tempLifeState[i, a] = CellLifeState.Alive; } else { tempLifeState[i, a] = CellLifeState.Dead; }
            }

            if (lifeState[i, a] == CellLifeState.Alive)
            {
                if (neighborAlive < 2 || neighborAlive > 3)
                {
                    tempLifeState[i, a] = CellLifeState.Dead;                   
                }
                else { tempLifeState[i, a] = CellLifeState.Alive; }
            }
        }
        private void ReadyToFlow(CellLifeState[,] lifeState )
        {
             for (; ; )
            {
                var tempLifeState = new CellLifeState[lifeState.GetLength(0), lifeState.GetLength(1)];
                for (int i = 0; i < generat.line; i++)
                {
                    for (int a = 0; a < generat.sing; a++)
                    {
                        Movement(i,a,lifeState,tempLifeState);
                       
                    }
                }

                lifeState = tempLifeState;
               
                //Thread.Sleep(100);
                DrawCellMatrix(lifeState);
            }
        }
        public async Task WaitAsync(CellLifeState[,] lifeState)
        {           
            await Task.Run(() => ReadyToFlow(lifeState));
           
        }
        private void Wait(CellLifeState[,] lifeState)
        {
            WaitAsync(lifeState);
            Console.ReadKey();
        }

       
       
    }
}

