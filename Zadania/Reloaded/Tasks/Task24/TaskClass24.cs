using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// UWAGI:
// 1.
//    for (; ; )
//    {
//        if (Console.ReadKey().Key == ConsoleKey.RightArrow)
//        {
//            wind.Wind += 3;
//            if (wind.Wind > 9) { wind.Wind = 9; }
//        }
//        if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
//        {
//            wind.Wind -= 3;
//            if (wind.Wind < -9) { wind.Wind = -9; }
//        }
//    }
//    W pozyższym jest ten problem, że w jednym przebiegu pętli robisz Console.ReadKey() dwa razy - i to dlatego musisz wdusić strzałkę dwa razy.
//    Żeby to działało jak trzeba to zróbi Console.ReadKey() tylko raz przypisując rezultat do jakiejś zmiennej:
//    var key = Console.ReadKey().Key;
//    a następnie w ifach wykorzystaj tę zmienną - dzięki temu zapytanie do konsoli pójdzie tylko raz i w oparciu o wynik możesz sobie potem robić tyle ifów ile Ci się podoba.
//
// 2.
//    int quantity = width / space;
//    int quantity2 = height / space;
//    Patrząc na nazwy quantity i quantity2 nie bardzo wiadomo dlaczego tam jest cyfra 2. Niewiele to mówi. Czytelniej było by to nazwać np. tak: widthQuantity i heightQuantity albo horizontalQunatity i verticalQuantity
//
// 3. var wind = new Snow();
//    Tu jest lekkie pomieszanie odpowiedzialności. Wiatr to nie śnieg. Poza tym to property Wind w klasie Snow do niczego nie służy.
//    Dlatego wiatr powinieneś reprezentować po prostu jako int - np. zrobić cosbie w klasie TaskClass24 prywatne pole typu int o nazwie _wind. Albo możesz sobie zrobić klasę Wind z jednym intowym property o nazwie Strength czyli był by wiatr, który miałby jakąś siłę.
//    No i oczywiście to też jako prywatne pole w klasie TaskClass24:
//    private Wind _wind; - i to pole inicjalizujesz w konstruktorze klasy TaskClass24:
//    _wind = new Wind();
//
// 4. const'a, a później zmienną flake przenazwij na flakeSize - będzie bardziej zrozumiałe czym jest ta wartość.
//
// 5. No i teraz taka uwaga, która już mi przyszła do głowy przy poprzednim zadaniu
//    czyli to odsunięcie od narożnika ekranu x=100 i y=100. Zauważ, że teraz wszędzie w kodzie musisz się z tym męczyć i o tym pamiętać.
//    No i to jest niezłe uciemiężenie bo musisz to przekazywać do różnych metod, wszędzie dodawać, odejmować itd., uwzględniać w ifach.
//    A przecież to pełni wyłącznie funkcję offsetu (przesunięcia) przy rysowaniu, a więc tylko tam to się powinno pojawiać.
//    Czyli zmień kod tak żeby tego w ogóle nie było w klasie TaskClass24, ani w ogóle nie było nigdzie w klasie Snow.
//    Jedyne miejsce gdzie te wartości powinny się pojawić to klasa Drawing - to dopier w tej klasie zrób sobie takie dwa consty:
//      private const int x = 100;
//      private const int y = 100;
//   I dodawaj to np. tutaj:
//   _graphics.FillEllipse(whiteBrush, Convert.ToSingle(snow.Position.X + x), Convert.ToSingle(snow.Position.Y + y), flake, flake);
//   Ułatwi Ci to życie i to mocno.
//   Kolejna sprawa - nazwij te consty nie x i y tylko xOffset i yOffset albo xDrawingOffset i yDrawingOffset żeby od razu było wiadomo, że chodzi o przesunięcie rysowania.
//
//  6. Ta dwuwymiarowa tablica płatków jest zbędna. Koniec końców chodzi Ci przecież po prostu o liczbę płatków zależną od rozmiaru pudełka.
//     Nie potrzebujesz do tego dwuwymiarowej tablicy.
//     Teraz masz takie coś:
//     quantity = width / space
//     quantity2 = height / space
//     tablica ma wymiar quantity * quantity2
//     a więc liczba płatków, którą masz w tej tablicy to jest quantity * quantity2
//     więc możesz sobie zrobić po prostu jednowymiarową tablicę:
//     Snow[] flakes = new Snow[quantity * quantity2]
//     a później iterować po niej:
//     for (int snowflakeIndex = 0; snowflakeIndex < flakes.Length; snowflakeIndex++)
//     Prościej bo nie potrzebujesz pętli w pętli.
//     ... do tematu da się podejść na jeszcze inny sposób:
//     Tak naprawdę to co chcesz uzyskać to uzależnić liczbę płatków od powierzchni pudełka, w którym te płatki latają.
//     Tzn. liczba płatków ma być wprost proporcjonalna do powierzchni pudełka więc możesz sobie napisać:
//     var boxArea = width * height;
//     a potem ustalić rozmiar tablicy jako boxArea podzielone przez jakąś stałą.
//     Oczywiście to co napisałem wyżej rozwala ten Twój kawałek kodu, który wywołuje metodę Start i przekazuje tam "i" do środka.
//     Rozumiem o co chodzi w tym kawałku kodu - o równomierne rozmieszczenie płatków. Ale możesz ten sam efekt uzyskać poprzez zwyczajne losowanie pozycji na osi X
//     przy pomocy _random - po prostu to musi być losowanie z zakresu od 0 do width i przy odpowiedniej liczbie płatków rozkład i tak będzie równomierny.
//     No, a w osi Y to powinna być losowana pozycja od -height to 0.
//     Bo z tego co widzę Twój kod dokładnie to teraz realizuje - tzn rozlosowuje płatki w pudełku leżącym tak jakby powyżej głównego pudełka i one zaczynają spadać,
//     a jak ich pozycja Y zaczyna wkraczać w normalne pudełko to dopiero wtedy się pojawiają.
//     Czyli to co proponuję powinno zadziałać czyli dla każego płatka pozycja X to jest random między 0, a width, a pozycja Y to jest random pomiędzy -height, a 0.
//
//  7. fList - to jest do wywalenia bo nie pełni żadnej funkcji - do nieczego to nie służy


namespace Reloaded.Tasks.Task24
{
    public class TaskClass24
    {
        private const int x = 100;
        private const int y = 100;
        private const int flake = 10;
        private int _wind = 0;

        public void Test()
        {
            //var _wind = new Snow();
            var drav = new Draving();
            var random = new Random();
            int width = random.Next(400, 600);
            int height = random.Next(200, 300);
            int space = flake * 3;
            int widthQuantity = width / space;
            int heightQuantiti = height / space;
            int firstspace = (space) / 2;
            var snow = new Snow(random, _wind);
            


            drav.Rect(width, height, x, y);

            Snow[,] flakes = new Snow[heightQuantiti, widthQuantity];

            List<Snow> fList = new List<Snow>();

            for (int a = 0; a < heightQuantiti; a++)
            {


                for (int i = 0; i < widthQuantity; i++)
                {
                    flakes[a, i] = new Snow();
                    snow.Start(flakes[a, i], firstspace, space, flake, i, x, y, a);
                    fList.Add(flakes[a, i]);
                }
            }

            var task = Flurry(widthQuantity, heightQuantiti, snow, flakes, width, height, _wind);
            for (; ; )
            {
                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.RightArrow)
                {
                    _wind += 3;
                    if (_wind > 9) { _wind = 9; }
                }
                if (key == ConsoleKey.LeftArrow)
                {
                    _wind -= 3;
                    if (_wind < -9) { _wind = -9; }
                }
            }

        }
        public async Task Flurry(int quantity, int quantity2, Snow snow, Snow[,] flakes, int width, int height, int _wind)
        {
            await Task.Run(() =>
            {
                for (; ; )
                {
                    for (int a = 0; a < quantity2; a++)
                    {


                        //Thread.Sleep(2);
                        for (int i = 0; i < quantity; i++)
                        {
                            snow.SMove(flakes[a, i], flake, width, height, x, y, _wind);
                        }
                    }
                }
            }
            );
        }
    }
}
